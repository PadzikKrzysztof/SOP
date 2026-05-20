using SOP_Administration.Models;
using SOP_ETOLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOP_Administration.Forms.Doctor
{
    public partial class DoctorVisitsListForm : Form
    {
        public DoctorVisitsListForm()
        {
            InitializeComponent();
        }

        public void LoadData(int doctorID)
        {
            var patientETOs = Patient.GetList();
            var patientsWithVisit = new List<DoctorVisit>();

            foreach (var patient in patientETOs)
            {
                foreach (var patientFile in patient.PatientFiles)
                {
                    foreach (var visit in patientFile.Visits)
                    {
                        if (visit.Doctor.ID == doctorID)
                        {
                            patientsWithVisit.Add(new DoctorVisit 
                            {
                                Name = patient.Name,
                                Surname = patient.Surname,
                                PatientFileID = patientFile.ID,
                                VisitID = visit.ID,
                                PatientETO = patient
                            });
                        }
                    }
                }
            }

            dataGridView.DataSource = patientsWithVisit;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            var doctorVisit = (DoctorVisit)dataGridView.Rows[e.RowIndex].DataBoundItem;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var form = new EditVisitForm();
                form.LoadData(doctorVisit.PatientETO, doctorVisit.PatientFileID, doctorVisit.VisitID);

                form.ShowDialog();
            }
        }
    }
}

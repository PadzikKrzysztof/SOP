using SOP_Administration.Models;
using SOP_ETOLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOP_Administration.Forms
{
    public partial class NewVisitForm : Form
    {
        private List<DoctorETO> _doctors;

        public PatientETO PatientETO;
        public int PatientFileID;
        public NewVisitForm()
        {
            InitializeComponent();
        }

        public void LoadData(PatientETO patientETO, int patientFileID)
        {
            PatientETO = patientETO;
            PatientFileID = patientFileID;
            _doctors = Doctor.GetList();
            foreach (var doctor in _doctors)
            {
                comboBox1.Items.Add($"{doctor.Employee.Name} {doctor.Employee.Surname}");
            }

            dateTimePicker1.Value = DateTime.Now;
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            var visit = new VisitETO
            {
                Day = dateTimePicker1.Value,
                Doctor = _doctors[comboBox1.SelectedIndex]
            };
            foreach (var file in PatientETO.PatientFiles)
            {
                if (file.ID == PatientFileID)
                {
                    file.Visits.Add(visit);

                    break;
                }
            }

            Patient.Put(PatientETO);

            Close();
        }
    }
}

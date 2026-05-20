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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SOP_Administration.Forms
{
    public partial class EditVisitForm : Form
    {
        private List<DoctorETO> _doctors;

        public PatientETO PatientETO;
        public int PatientFileID;
        public int VisitID;
        public EditVisitForm()
        {
            InitializeComponent();
        }
        public void LoadData(PatientETO patientETO, int patientFileID, int visitID)
        {
            PatientETO = patientETO;
            PatientFileID = patientFileID;
            VisitID = visitID;
            var visit = patientETO
                .PatientFiles.First(x => x.ID == PatientFileID)
                .Visits.First(x => x.ID == VisitID);
            _doctors = Models.Doctor.GetList();
            var index = 0;
            foreach (var doctor in _doctors)
            {
                var pos = $"{doctor.Employee.Name} {doctor.Employee.Surname}";
                comboBoxDoctor.Items.Add(pos);
                if (pos == $"{visit.Doctor.Employee.Name} {visit.Doctor.Employee.Surname}")
                {
                    comboBoxDoctor.SelectedIndex = index;
                }

                index++;
            }

            dateTimePicker.Value = visit.Day;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var visit = new VisitETO
            {
                Day = dateTimePicker.Value,
                Doctor = _doctors[comboBoxDoctor.SelectedIndex]
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

            SendInfo();
            Close();
        }
        private void SendInfo() { }
    }
}

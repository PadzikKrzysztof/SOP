using SOP_Administration.Models;
using SOP_ETOLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SOP_Administration.Forms
{
    public partial class NewVisitForm : Form
    {
        private List<DoctorETO> _doctors = new List<DoctorETO>();

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
            GetDoctors();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void GetDoctors()
        {
            if (_doctors.Count == 0)
            {
                _doctors = Models.Doctor.GetList();
            }
            foreach (var doctor in _doctors)
            {
                comboBox1.Items.Clear();
                comboBox1.Text = "";
                var visitTime = dateTimePicker1.Value;
                if (doctor.Availabilites.Any(x => x.DayTimeStart <= visitTime && x.DayTimeEnd >= visitTime))
                {
                    comboBox1.Items.Add($"{doctor.Employee.Name} {doctor.Employee.Surname}");
                }
            }
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

            SendInfo();
            Close();

        }

        private void SendInfo() { }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            GetDoctors();
        }
    }
}

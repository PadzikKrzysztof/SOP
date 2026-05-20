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
    public partial class PatientFileForm : Form
    {
        public PatientETO PatientETO;
        public int PatientFileID;
        public PatientFileForm()
        {
            InitializeComponent();
        }

        public void LoadData(PatientETO patientETO, int patientFileID = 0)
        { 
            PatientFileID = patientFileID;
            PatientETO = patientETO;
            if (PatientFileID != 0)
            {
                var patientFile = patientETO.PatientFiles.First(x => x.ID == PatientFileID);
                textBoxName.Text = patientFile.Name;
                textBoxDescription.Text = patientFile.Description;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            PatientETO.PatientFiles.Add(new PatientFileETO 
            {
                Name = textBoxName.Text,
                Description = textBoxDescription.Text,
            });

            Patient.Put(PatientETO);

            this.Close();
        }
    }
}

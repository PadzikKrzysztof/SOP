using SOP_Administration.Forms;
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

namespace SOP_Administration.Colntrols
{
    public partial class PatientListControl : UserControl
    {
        public PatientListControl()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dataGridView.DataSource = Patient.GetList();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            var newPatientForm = new NewPatientForm();
            newPatientForm.ShowDialog();
            LoadData();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            var patientEditForm = new PatientEditForm();
            if (dataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            patientEditForm.LoadData((PatientETO)dataGridView.SelectedRows[0].DataBoundItem);
            patientEditForm.ShowDialog();
            LoadData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            var eto = (PatientETO)dataGridView.SelectedRows[0].DataBoundItem;
            Patient.Delete(eto.ID);
            LoadData();
        }
    }
}

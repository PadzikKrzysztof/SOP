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
    public partial class DoctorListControl : UserControl
    {
        public DoctorListControl()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            dataGridView.DataSource = Doctor.GetList();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            var newPatientForm = new Forms.DoctorForm();
            newPatientForm.ShowDialog();
            LoadData();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            var patientEditForm = new DoctorForm();
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Wybierz Lekarza");
                return;
            }

            patientEditForm.LoadData((DoctorETO)dataGridView.SelectedRows[0].DataBoundItem);
            patientEditForm.ShowDialog();
            LoadData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Wybierz Lekarza");
                return;
            }

            var eto = (DoctorETO)dataGridView.SelectedRows[0].DataBoundItem;
            Models.Doctor.Delete(eto.ID);
            LoadData();
        }

        private void buttonNew_Click_1(object sender, EventArgs e)
        {
            var doctorForm = new DoctorForm();

            doctorForm.LoadData();
            doctorForm.ShowDialog();
            LoadData();
        }

        private void buttonRefresh_Click_1(object sender, EventArgs e)
        {
            var doctorForm = new DoctorForm();

            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Wybierz Lekarza");
                return;
            }

            var eto = (DoctorETO)dataGridView.SelectedRows[0].DataBoundItem;
            doctorForm.LoadData(eto);
            doctorForm.ShowDialog();
            LoadData();
        }
    }
}

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
    public partial class PatientEditForm : Form
    {
        public PatientETO PatientETO { get; set; }

        public PatientEditForm()
        {
            InitializeComponent();
        }

        public void LoadData(PatientETO patient)
        {
            PatientETO = patient;
            textBoxName.Text = PatientETO.Name;
            textBoxSurname.Text = PatientETO.Surname;
            textBoxPesel.Text = PatientETO.PESEL.ToString();
            dataGridView.DataSource = PatientETO.PatientFiles;
            Text = $"Pacjent: {PatientETO.Name} {PatientETO.Surname}";
            Refresh();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Wpisz Imię");

                return;
            }


            if (string.IsNullOrEmpty(textBoxSurname.Text))
            {
                MessageBox.Show("Wpisz Nazwisko");

                return;
            }
            int pesel;

            if (string.IsNullOrEmpty(textBoxPesel.Text) ||
                !int.TryParse(textBoxPesel.Text, out pesel))
            {
                MessageBox.Show("Wpisz poprawny Pesel");

                return;
            }
            var eto = new Patient
            {
                ID = PatientETO.ID,
                Name = textBoxName.Text,
                Surname = textBoxSurname.Text,
                PESEL = pesel,
                PatientFiles = new List<PatientFileETO>(),
                LoginProfile = PatientETO.LoginProfile
            };

            Patient.Put(eto);
            this.Close();
        }

        private void buttonNewPatientFile_Click(object sender, EventArgs e)
        {
            var form = new PatientFileForm();
            form.LoadData(PatientETO);
            form.ShowDialog();

            LoadData(Patient.Get(PatientETO.ID));
        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nie zaznaczono Kartoteki");
                return;
            }
            var patientFile = (PatientFileETO)dataGridView.SelectedRows[0].DataBoundItem;

            dataGridViewVisit.DataSource = patientFile.Visits;
            dataGridViewLAbTest.DataSource = patientFile.LabTests;
        }

        private void buttonAddVisit_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nie zaznaczono Kartoteki");
                return;
            }
            var patientFile = (PatientFileETO)dataGridView.SelectedRows[0].DataBoundItem;

            var form = new NewVisitForm();
            form.LoadData(PatientETO, patientFile.ID);
            form.ShowDialog();

            LoadData(Patient.Get(PatientETO.ID));
        }

        private void buttonEditVisit_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nie zaznaczono Kartoteki");
                return;
            }
            var patientFile = (PatientFileETO)dataGridView.SelectedRows[0].DataBoundItem;

            MessageBox.Show("Nie zaznaczono wizyty");
            if (dataGridViewVisit.SelectedRows.Count == 0)
            {
                return;
            }
            var visit = (VisitETO)dataGridViewVisit.SelectedRows[0].DataBoundItem;
            var form = new EditVisitForm();
            form.LoadData(PatientETO, patientFile.ID, visit.ID);
            form.ShowDialog();

            LoadData(Patient.Get(PatientETO.ID));
        }

        private void buttonDeleteVisit_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nie zaznaczono Kartoteki");
                return;
            }
            var patientFile = (PatientFileETO)dataGridView.SelectedRows[0].DataBoundItem;

            if (dataGridViewVisit.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nie zaznaczono wizyty");
                return;
            }
            var visit = (VisitETO)dataGridViewVisit.SelectedRows[0].DataBoundItem;

            foreach (var files in PatientETO.PatientFiles)
            {
                files.Visits.Remove(visit);
            }

            Patient.Put(PatientETO);

            LoadData(Patient.Get(PatientETO.ID));
        }

        private void buttonAddTest_Click(object sender, EventArgs e)
        {

        }

        private void buttonEditTest_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteTest_Click(object sender, EventArgs e)
        {

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadData(Patient.Get(PatientETO.ID));
        }

        private void buttonEditFile_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nie zaznaczono Kartoteki");
                return;
            }
            var patientFile = (PatientFileETO)dataGridView.SelectedRows[0].DataBoundItem;

            if (patientFile.Visits.Any())
            {
                MessageBox.Show("Kartoteka zawiera wizyty, nie można usunąć");

                return;
            }

            if (patientFile.Visits.Any())
            {
                MessageBox.Show("Kartoteka zawiera badania, nie można usunąć");

                return;
            }

            PatientETO.PatientFiles.Remove(patientFile);

            Patient.Put(PatientETO);

            LoadData(Patient.Get(PatientETO.ID));
        }
    }
}

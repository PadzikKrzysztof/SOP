//using SOP_ETOLibrary;
using SOP_Administration.Models;
using SOP_ETOLibrary;

namespace SOP_Administration.Forms
{
    public partial class NewPatientForm : Form
    {
        public NewPatientForm()
        {
            InitializeComponent();
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
                Name = textBoxName.Text,
                Surname = textBoxSurname.Text,
                PESEL = pesel,
                PatientFiles = new List<PatientFileETO>()
            };

            Patient.Put(eto);
            this.Close();
        }
    }
}

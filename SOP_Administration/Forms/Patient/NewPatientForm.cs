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
            long pesel;

            if (string.IsNullOrEmpty(textBoxPesel.Text) ||
                !long.TryParse(textBoxPesel.Text, out pesel))
            {
                MessageBox.Show("Wpisz poprawny Pesel");

                return;
            }

            if (string.IsNullOrEmpty(textBoxEmail.Text))
            {
                MessageBox.Show("Wpisz Email");

                return;
            }

            long phoneNumber;

            if (string.IsNullOrEmpty(textBoxPhone.Text) ||
                !long.TryParse(textBoxPhone.Text, out phoneNumber))
            {
                MessageBox.Show("Wpisz poprawny numer telefonu");

                return;
            }

            var loginETO = new LoginProfileETO
            {
                Login = textBoxEmail.Text,
                Password = textBoxPassword.Text,
            };

            var eto = new Patient
            {
                Name = textBoxName.Text,
                Surname = textBoxSurname.Text,
                PESEL = pesel,
                Email = textBoxEmail.Text,
                PhoneNumber = phoneNumber,
                PatientFiles = new List<PatientFileETO>(),
                LoginProfile = loginETO
            };

            Patient.Post(eto);
            this.Close();
        }
    }
}

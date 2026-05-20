using SOP_Administration.Forms.Doctor.Avability;
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
    public partial class DoctorControl : UserControl
    {
        public DoctorETO DoctorETO;
        public List<SpecializationEnumETO> Specializations = new List<SpecializationEnumETO>();
        public List<AvailabilityETO> Availabilites = new List<AvailabilityETO>();
        public DoctorControl()
        {
            InitializeComponent();
        }

        public void LoadData(DoctorETO doctorETO = null, bool isForm = false)
        {
            buttonSave.Visible = isForm;
            DoctorETO = doctorETO;
            if (Specializations.Count == 0)
            {
                Specializations = SlecializationEnum.GetList();
                comboBoxSpecialization.Items.Clear();
                foreach (var specialization in Specializations)
                {
                    comboBoxSpecialization.Items.Add(specialization.Name);
                }
            }

            if (DoctorETO != null)
            {
                textBoxName.Text = doctorETO.Employee.Name;
                textBoxSurname.Text = doctorETO.Employee.Surname;
                textBoxEmail.Text = doctorETO.Employee.Email;
                textBoxPhone.Text = doctorETO.Employee.PhoneNumber.ToString();
                textBoxPassword.Text = doctorETO.Employee.LoginProfile.Password;
                comboBoxSpecialization.Text = doctorETO.Specialization.Name;
            }
            else
            {
                DoctorETO = new DoctorETO();
                DoctorETO.Availabilites = Availabilites;

                dataGridView.Enabled = false;
                buttonAdd.Enabled = false;
                buttonDelete.Enabled = false;
                buttonEdit.Enabled = false;
            }

            dataGridView.DataSource = Availabilites;
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

            var eto = new DoctorETO
            {
                Employee = new EmployeeETO
                {
                    Name = textBoxName.Text,
                    Surname = textBoxSurname.Text,
                    Email = textBoxEmail.Text,
                    PhoneNumber = phoneNumber,
                    LoginProfile = loginETO
                },
                Specialization = Specializations.First(x => x.Name == comboBoxSpecialization.Text),
                Availabilites = Availabilites
            };

            Models.Doctor.Put(eto);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = new AvabilityForm();
            form.LoadData(DoctorETO);
            form.ShowDialog();

            LoadData(Models.Doctor.Get(DoctorETO.ID));
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nie zaznaczono dostępności");
                return;
            }
            var avability = (AvailabilityETO)dataGridView.SelectedRows[0].DataBoundItem;

            var form = new AvabilityForm();
            form.LoadData(DoctorETO, avability.ID);
            form.ShowDialog();

            LoadData(Models.Doctor.Get(DoctorETO.ID));
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nie zaznaczono dostępności");
                return;
            }
            var avability = (AvailabilityETO)dataGridView.SelectedRows[0].DataBoundItem;

            DoctorETO.Availabilites.Remove(avability);

            Models.Doctor.Put(DoctorETO);

            LoadData(Models.Doctor.Get(DoctorETO.ID));
        }
    }
}

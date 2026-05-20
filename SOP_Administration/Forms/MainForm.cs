using SOP_Administration.Colntrols;
using SOP_Administration.Forms;
using SOP_Administration.HttpConnection;
using SOP_Administration.Models;
using SOP_ETOLibrary;

namespace SOP_Administration
{
    public partial class FormSOP : Form
    {
        public FormSOP()
        {
            var loginForm = new LoginForm();
            loginForm.ShowDialog();

            if (!loginForm.IsOk)
            {
                return;
            }

            InitializeComponent();

            if (loginForm.Role == SystemRole.Admin 
                || loginForm.Role == SystemRole.Registration)
            {
                var patientsListTab = new TabPage();
                patientsListTab.Text = "Pacjenci";
                patientsListTab.Controls.Add(new PatientListControl());
                tabControl.TabPages.Add(patientsListTab);
            }

            if (loginForm.Role == SystemRole.Admin
                || loginForm.Role == SystemRole.Registration)
            {
                var doctorListTab = new TabPage();
                doctorListTab.Text = "Lekarze";
                doctorListTab.Controls.Add(new DoctorListControl());
                tabControl.TabPages.Add(doctorListTab);
            }

            if (loginForm.Role == SystemRole.Doctor)
            {
                var doctorListTab = new TabPage();
                doctorListTab.Text = $"{loginForm.Doctor.Employee.Name} {loginForm.Doctor.Employee.Surname}";
                var doctorControl = new DoctorControl();
                doctorControl.LoadData(loginForm.Doctor);
                doctorListTab.Controls.Add(new DoctorControl());
                tabControl.TabPages.Add(doctorListTab);
            }
        }
    }
}

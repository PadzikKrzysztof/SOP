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

            if (!loginForm.isOk)
            {
                return;
            }

            InitializeComponent();

            if (loginForm.role == SystemRole.Admin 
                || loginForm.role == SystemRole.Registration)
            {
                var patientsListTab = new TabPage();
                patientsListTab.Text = "Pacjenci";
                patientsListTab.Controls.Add(new PatientListControl());
                tabControl.TabPages.Add(patientsListTab);
            }
        }
    }
}

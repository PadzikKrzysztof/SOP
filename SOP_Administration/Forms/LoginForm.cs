using SOP_Administration.HttpConnection;
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
    public partial class LoginForm : Form
    {
        public bool IsOk = false;
        public SystemRole Role = SystemRole.None;
        public DoctorETO Doctor = null;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            var loginProfiles = LoginProfile.GetList();
            var loginProfile = loginProfiles.FirstOrDefault(x => x.Login == textBoxLogin.Text && x.Password == textBoxPassword.Text);
            if (loginProfile == null)
            {
                IsOk = false;

                return;
            }
            IsOk = true;

            HttpHandler.Authorize(SystemRole.LogedIn);
            Role = HttpHandler.GetRole(loginProfile.ID);

            HttpHandler.Authorize(Role);
            if (Role == SystemRole.Doctor)
            {
                var employee = Employee.GetList().First(x => x.LoginProfile.ID == loginProfile.ID);
                var doctor = Models.Doctor.GetList().First(x => x.Employee.ID == employee.ID);

                Doctor = doctor;
            }

            this.Close();
        }
    }
}

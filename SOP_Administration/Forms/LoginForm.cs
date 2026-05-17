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
        public bool isOk = false;
        public SystemRole role = SystemRole.None;
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
                isOk = false;

                return;
            }
            isOk = true;

            HttpHandler.Authorize(SystemRole.LogedIn);
            role = HttpHandler.GetRole(loginProfile.ID);

            HttpHandler.Authorize(role);

            this.Close();
        }
    }
}

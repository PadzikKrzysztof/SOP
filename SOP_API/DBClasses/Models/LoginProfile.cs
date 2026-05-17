using SOP_ETOLibrary;
using System.Xml.Linq;

namespace SOP_API.DBClasses.Models
{
    public class LoginProfile
    {
        private int _ID;
        private string _login;
        private string _password;

        public virtual int ID { get => _ID; set => _ID = value; }
        public virtual string Login { get => _login; set => _login = value; }
        public virtual string Password { get => _password; set => _password = value; }
        public virtual LoginProfileETO ToETO()
        {
            return new LoginProfileETO
            {
                ID = ID,
                Login = Login,
                Password = Password,
            };
        }

        public virtual LoginProfile FromETO(LoginProfileETO eto)
        {
            return new LoginProfile
            {
                ID = eto.ID,
                Login = eto.Login,
                Password = eto.Password,
            };
        }
    }
}

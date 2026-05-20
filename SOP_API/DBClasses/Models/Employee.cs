using FluentNHibernate.Infrastructure;
using SOP_ETOLibrary;

namespace SOP_API.DBClasses.Models
{
    public class Employee
    {
        private int _ID;
        private string _name;
        private string _surname;
        private string _email;
        private long _phoneNumber;
        private LoginProfile _loginProfile;

        public virtual int ID { get => _ID; set => _ID = value; }
        public virtual string Name { get => _name; set => _name = value; }
        public virtual string Surname { get => _surname; set => _surname = value; }
        public virtual string Email { get => _email; set => _email = value; }
        public virtual long PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        public virtual LoginProfile LoginProfile { get => _loginProfile; set => _loginProfile = value; }
        public virtual EmployeeETO ToETO()
        {
            return new EmployeeETO
            {
                ID = ID,
                Name = Name,
                Surname = Surname,
                Email = Email,
                PhoneNumber = PhoneNumber,
                LoginProfile = LoginProfile.ToETO()
            };
        }

        public virtual Employee FromETO(EmployeeETO eto)
        {
            LoginProfile = new LoginProfile();
            return new Employee
            {
                ID = eto.ID,
                Name = eto.Name,
                Surname = eto.Surname,
                Email = eto.Email,
                PhoneNumber = eto.PhoneNumber,
                LoginProfile = LoginProfile.FromETO(eto.LoginProfile),
            };
        }
    }
}

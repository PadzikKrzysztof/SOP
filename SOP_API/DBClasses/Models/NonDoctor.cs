using System.Data;

namespace SOP_API.DBClasses.Models
{
    public class NonDoctor
    {
        private int _ID;
        private RoleEnum _role;
        private Employee _employee;

        public virtual int ID { get => _ID; set => _ID = value; }
        public virtual RoleEnum Role { get => _role; set => _role = value; }
        public virtual Employee Employee { get => _employee; set => _employee = value; }
    }
}

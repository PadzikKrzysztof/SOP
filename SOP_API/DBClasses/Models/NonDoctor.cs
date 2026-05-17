using NHibernate.Mapping;
using SOP_ETOLibrary;
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
        public virtual NonDoctorETO ToETO()
        {
            return new NonDoctorETO
            {
                ID = ID,
                Role = Role.ToETO(),
                Employee = Employee.ToETO(),
            };
        }

        public virtual NonDoctor FromETO(NonDoctorETO eto)
        {
            return new NonDoctor
            {
                ID = eto.ID,
                Role = Role.FromETO(eto.Role),
                Employee = Employee.FromETO(eto.Employee),
            };
        }
    }
}

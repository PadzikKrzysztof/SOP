using FluentNHibernate.Infrastructure;

namespace SOP_API.DBClasses.Models
{
    public class Doctor
    {
        private int _ID;
        private DoctorSpecializationEnum _specialization;
        private Employee _employee;

        public virtual int ID { get => _ID; set => _ID = value; }
        public virtual DoctorSpecializationEnum Specialization { get => _specialization; set => _specialization = value; }
        public virtual Employee Employee { get => _employee; set => _employee = value; }
    }
}

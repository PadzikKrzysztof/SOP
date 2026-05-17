using FluentNHibernate.Infrastructure;
using SOP_ETOLibrary;

namespace SOP_API.DBClasses.Models
{
    public class Doctor
    {
        private int _ID;
        private SpecializationEnum _specialization;
        private Employee _employee;
        private IList<Availability> _availabilites;

        public virtual int ID { get => _ID; set => _ID = value; }
        public virtual SpecializationEnum Specialization { get => _specialization; set => _specialization = value; }
        public virtual Employee Employee { get => _employee; set => _employee = value; }
        public virtual IList<Availability> Availabilites { get => _availabilites; set => _availabilites = value; }
        public virtual DoctorETO ToETO()
        {
            var avabilityETOs = new List<AvailabilityETO>();
            foreach (var item in Availabilites)
            {
                avabilityETOs.Add(item.ToETO());
            }

            return new DoctorETO
            {
                ID = ID,
                Specialization = Specialization.ToETO(),
                Employee = Employee.ToETO(),
                Availabilites = avabilityETOs
            };
        }

        public virtual Doctor FromETO(DoctorETO eto)
        {
            var availabilites = new List<Availability>();

            foreach (var item in eto.Availabilites)
            {
                var av = new Availability();
                availabilites.Add(av.FromETO(item));
            }
            Specialization = new SpecializationEnum();
            Employee = new Employee();
            return new Doctor
            {
                ID = eto.ID,
                Specialization = Specialization.FromETO(eto.Specialization),
                Employee = Employee.FromETO(eto.Employee),
                Availabilites = availabilites,
            };
        }
    }
}

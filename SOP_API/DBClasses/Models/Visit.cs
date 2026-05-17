using SOP_ETOLibrary;
using System.Xml.Linq;

namespace SOP_API.DBClasses.Models
{
    public class Visit
    {
        private int _ID;
        private DateTime _day;
        private Doctor _doctor;

        public virtual int ID { get => _ID; set => _ID = value; }
        public virtual Doctor Doctor { get => _doctor; set => _doctor = value; }
        public virtual DateTime Day { get => _day; set => _day = value; }
        public virtual VisitETO ToETO()
        {
            return new VisitETO
            {
                ID = ID,
                Doctor = Doctor.ToETO(),
                Day = Day,
            };
        }

        public virtual Visit FromETO(VisitETO eto)
        {
            Doctor = new Doctor();

            return new Visit
            {
                ID = eto.ID,
                Doctor = Doctor.FromETO(eto.Doctor),
                Day = eto.Day,
            };
        }
    }
}

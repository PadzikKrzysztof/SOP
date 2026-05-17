using SOP_ETOLibrary;

namespace SOP_API.DBClasses.Models
{
    public class Availability
    {
        private int _ID;
        private DateTime _dayTimeStart;
        private DateTime _dayTimeEnd;
        private Doctor _doctor;

        public virtual int ID { get => _ID; set => _ID = value; }
        public virtual DateTime DayTimeStart { get => _dayTimeStart; set => _dayTimeStart = value; }
        public virtual DateTime DayTimeEnd { get => _dayTimeEnd; set => _dayTimeEnd = value; }
        public virtual Doctor Doctor { get => _doctor; set => _doctor = value; }

        public virtual AvailabilityETO ToETO()
        {
            return new AvailabilityETO
            {
                ID = ID,
                DayTimeStart = DayTimeStart,
                DayTimeEnd = DayTimeEnd,
                Doctor = Doctor.ToETO()
            };
        }
        public virtual Availability FromETO(AvailabilityETO eto)
        {
            return new Availability
            {
                ID = eto.ID,
                DayTimeStart = eto.DayTimeStart,
                DayTimeEnd = eto.DayTimeEnd,
                Doctor = Doctor.FromETO(eto.Doctor)
            };
        }
    }
}

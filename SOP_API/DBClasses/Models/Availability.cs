namespace SOP_API.DBClasses.Models
{
    public class Availability
    {
        private int _ID;
        private DateTime _timeStart;
        private DateTime _timeEnd;
        private Doctor _doctor;
        private Day _day;

        public virtual int ID { get => _ID; set => _ID = value; }
        public virtual DateTime TimeStart { get => _timeStart; set => _timeStart = value; }
        public virtual DateTime TimeEnd { get => _timeEnd; set => _timeEnd = value; }
        public virtual Doctor Doctor { get => _doctor; set => _doctor = value; }
        public virtual Day Day { get => _day; set => _day = value; }
    }
}

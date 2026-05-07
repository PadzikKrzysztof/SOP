namespace SOP_API.DBClasses.Models
{
    public class Day
    {
        private int _ID;
        private int _dayOfMonth;
        private MonthEnum _month;
        private int _year;

        public virtual int ID { get => _ID; set => _ID = value; }
        public virtual int DayOfMonth { get => _dayOfMonth; set => _dayOfMonth = value; }
        public virtual MonthEnum Month { get => _month; set => _month = value; }
        public virtual int Year { get => _year; set => _year = value; }
    }
}

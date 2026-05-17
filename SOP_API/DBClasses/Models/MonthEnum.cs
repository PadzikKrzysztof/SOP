using SOP_ETOLibrary;

namespace SOP_API.DBClasses.Models
{
    public class MonthEnum
    {
        private int _ID;
        private string _name;
        public virtual int ID { get => _ID; set => _ID = value; }
        public virtual string Name { get => _name; set => _name = value; }
        public virtual MonthEnumETO ToETO()
        {

            return new MonthEnumETO
            {
                ID = ID,
                Name = Name
            };
        }

        public virtual MonthEnum FromETO(MonthEnumETO eto)
        {

            return new MonthEnum
            {
                ID = eto.ID,
                Name = eto.Name
            };
        }
    }
}

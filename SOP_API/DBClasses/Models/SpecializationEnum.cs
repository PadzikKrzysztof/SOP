using FluentNHibernate.Infrastructure;
using SOP_ETOLibrary;

namespace SOP_API.DBClasses.Models
{
    public class SpecializationEnum
    {
        private int _ID;
        private string _name;
        public virtual int ID { get => _ID; set => _ID = value; }
        public virtual string Name { get => _name; set => _name = value; }
        public virtual SpecializationEnumETO ToETO()
        {

            return new SpecializationEnumETO
            {
                ID = ID,
                Name = Name
            };
        }

        public virtual SpecializationEnum FromETO(SpecializationEnumETO eto)
        {

            return new SpecializationEnum
            {
                ID = eto.ID,
                Name = eto.Name
            };
        }
    }
}

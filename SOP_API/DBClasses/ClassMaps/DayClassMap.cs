using FluentNHibernate.Mapping;
using SOP_API.DBClasses.Models;

namespace SOP_API.DBClasses.ClassMaps
{
    public class DayClassMap: ClassMap<Day>
    {
        public DayClassMap()
        {
            Id(x => x.ID);
            Map(x => x.DayOfMonth);
            References(x => x.Month).Column("Month");
            Map(x => x.Year);
            Table("Day");
        }
    }
}

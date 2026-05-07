using FluentNHibernate.Mapping;
using SOP_API.DBClasses.Models;

namespace SOP_API.DBClasses.ClassMaps
{
    public class MonthEnumClassMap : ClassMap<MonthEnum>
    {
        public MonthEnumClassMap()
        {
            Id(x => x.ID);
            Map(x => x.Name);
            Table("MonthEnum");
        }
    }
}

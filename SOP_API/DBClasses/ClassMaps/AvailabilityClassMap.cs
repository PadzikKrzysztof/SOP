using FluentNHibernate.Mapping;
using SOP_API.DBClasses.Models;

namespace SOP_API.DBClasses.ClassMaps
{
    public class AvailabilityClassMap : ClassMap<Availability>
    {
        public AvailabilityClassMap()
        {
            Id(x => x.ID).Column("ID").Not.Nullable();
            Map(x => x.DayTimeStart).Column("DayTimeStart").Not.Nullable();
            Map(x => x.DayTimeEnd).Column("DayTimeeEnd").Not.Nullable();
            Table("Availability");
        }
    }
}

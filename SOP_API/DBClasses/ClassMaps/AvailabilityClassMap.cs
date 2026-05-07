using FluentNHibernate.Mapping;
using SOP_API.DBClasses.Models;

namespace SOP_API.DBClasses.ClassMaps
{
    public class AvailabilityClassMap : ClassMap<Availability>
    {
        public AvailabilityClassMap()
        {
            Id(x => x.ID).Column("ID").Not.Nullable();
            Map(x => x.TimeStart).Column("TimeStart").Not.Nullable();
            Map(x => x.TimeEnd).Column("TimeEnd").Not.Nullable();
            References(x => x.Doctor).Column("DoctorID").Not.Nullable();
            References(x => x.Day).Column("DayID").Not.Nullable();
            Table("Availability");
        }
    }
}

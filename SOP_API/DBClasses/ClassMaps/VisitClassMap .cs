using FluentNHibernate.Mapping;
using SOP_API.DBClasses.Models;

namespace SOP_API.DBClasses.ClassMaps
{
    public class VisitClassMap : ClassMap<Visit>
    {
        public VisitClassMap()
        {
            Id(x => x.ID).Column("ID").Not.Nullable();
            Map(x => x.Day).Column("Day").Not.Nullable();
            References(x => x.Doctor).Column("DoctorID").Not.Nullable().LazyLoad();
            Table("Visit");
        }
    }
}

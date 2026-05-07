using FluentNHibernate.Mapping;
using SOP_API.DBClasses.Models;

namespace SOP_API.DBClasses.ClassMaps
{
    public class RoleEnumClassMap : ClassMap<RoleEnum>
    {
        public RoleEnumClassMap()
        {
            Id(x => x.ID);
            Map(x => x.Name).Column("Name");
            Table("RoleEnum");
        }
    }
}

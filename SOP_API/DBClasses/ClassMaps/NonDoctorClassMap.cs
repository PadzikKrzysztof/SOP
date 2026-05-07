using FluentNHibernate.Mapping;
using SOP_API.DBClasses.Models;

namespace SOP_API.DBClasses.ClassMaps
{
    public class NonDoctorClassMap : ClassMap<NonDoctor>
    {
        public NonDoctorClassMap()
        {
            Id(x => x.ID);
            References(x => x.Role).Column("Role");
            References(x => x.Employee).Column("EmployeeID");
            Table("NonDoctor");
        }
    }
}

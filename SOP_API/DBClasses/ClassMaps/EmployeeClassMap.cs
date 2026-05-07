using FluentNHibernate.Mapping;
using SOP_API.DBClasses.Models;

namespace SOP_API.DBClasses.ClassMaps
{
    public class EmployeeClassMap : ClassMap<Employee>
    {
        public EmployeeClassMap()
        {
            Id(x => x.ID);
            Map(x => x.Name).Column("Name");
            Map(x => x.Surname).Column("Surname");
            References(x => x.PaymentInfo).Column("PaymentInfoID");
            Table("Employee");
        }
    }
}

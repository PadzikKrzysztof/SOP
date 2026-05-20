using FluentNHibernate.Mapping;
using SOP_API.DBClasses.Models;
using System.Security.Cryptography.Xml;

namespace SOP_API.DBClasses.ClassMaps
{
    public class EmployeeClassMap : ClassMap<Employee>
    {
        public EmployeeClassMap()
        {
            Id(x => x.ID);
            Map(x => x.Name).Column("Name");
            Map(x => x.Surname).Column("Surname");
            Map(x => x.Email).Column("Email");
            Map(x => x.PhoneNumber).Column("PhoneNumber");
            References(x => x.LoginProfile).Column("LoginProfileID").Cascade.SaveUpdate();
            Table("Employee");
        }
    }
}

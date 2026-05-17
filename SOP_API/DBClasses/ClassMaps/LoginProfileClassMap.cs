using FluentNHibernate.Mapping;
using SOP_API.DBClasses.Models;

namespace SOP_API.DBClasses.ClassMaps
{
    public class LoginProfileClassMap : ClassMap<LoginProfile>
    {
        public LoginProfileClassMap()
        {
            Id(x => x.ID);
            Map(x => x.Login);
            Map(x => x.Password);
            Table("LoginProfile");
        }
    }
}

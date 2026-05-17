using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using SOP_API.DBClasses.ClassMaps;

namespace SOP_API.DBConnection
{
    public class SessionFactory
    {
        public static ISessionFactory SessionFactoryInstance { get; private set; }
        private static string _connectionString;
        public static void CreateSessionFactory(string connectionString)
        {
            _connectionString = connectionString;
            SessionFactoryInstance = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008
                    .ConnectionString(_connectionString))
                .Mappings(m =>
                    m.FluentMappings
                    .AddFromAssemblyOf<RoleEnumClassMap>())
              .BuildSessionFactory();
        }

        //sopAdmin
        //Sop@dmin
        //Sop@dmin123123
    }
}

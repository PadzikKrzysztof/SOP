using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using SOP_API.DBClasses.ClassMaps;

namespace SOP_API.DBConnection
{
    public class SessionFactory
    {
        public static ISessionFactory SessionFactoryInstance { get; private set; }
        private static string _connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SOP_DataBase;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        public static void CreateSessionFactory()
        {
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

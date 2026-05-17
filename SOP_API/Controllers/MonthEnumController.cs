using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NHibernate;
using SOP_API.DBClasses.Models;
using SOP_API.DBConnection;
using SOP_ETOLibrary;

namespace SOP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonthEnumController : ControllerBase, IBaseController<MonthEnumETO>
    {
        [HttpDelete("{ID:int}")]
        public void Delete(int ID)
        {
            var role = RoleParser.Parse(HttpContext.Request.Headers["Role"]);
            if (role != SystemRole.Director && role != SystemRole.Registration && role != SystemRole.Admin)
            {
                return;
            }
            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            var transaction = session.BeginTransaction();
            var entity = session.Get<MonthEnum>(ID);
            session.Delete(entity);
            transaction.Commit();
        }

        [HttpGet]
        public IEnumerable<MonthEnumETO> Get()
        {
            var role = RoleParser.Parse(HttpContext.Request.Headers["Role"]);
            if (role != SystemRole.Director && role != SystemRole.Registration && role != SystemRole.Admin)
            {
                return Enumerable.Empty<MonthEnumETO>();
            }

            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            session.BeginTransaction();
            var monthEnums = session.Query<MonthEnum>();
            var resault = new List<MonthEnumETO>();
            foreach (var item in monthEnums)
            {
                resault.Add(item.ToETO());
            }
            return resault;
        }

        [HttpGet("{ID:int}")]
        public MonthEnumETO Get(int ID)
        {
            var role = RoleParser.Parse(HttpContext.Request.Headers["Role"]);
            if (role != SystemRole.Director && role != SystemRole.Registration && role != SystemRole.Admin)
            {
                return null;
            }
            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            session.BeginTransaction();
            var monthEnum = session.Get<MonthEnum>(ID);

            return monthEnum.ToETO();
        }

        [HttpPost]
        public void Post(MonthEnumETO eto)
        {
            var role = RoleParser.Parse(HttpContext.Request.Headers["Role"]);
            if (role != SystemRole.Director && role != SystemRole.Registration && role != SystemRole.Admin)
            {
                return;
            }
            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            var transaction = session.BeginTransaction();
            var month = new MonthEnum();
            session.Save(month.FromETO(eto));

            transaction.Commit();
        }

        [HttpPut]
        public void Put(MonthEnumETO eto)
        {
            var role = RoleParser.Parse(HttpContext.Request.Headers["Role"]);
            if (role != SystemRole.Director && role != SystemRole.Registration && role != SystemRole.Admin)
            {
                return;
            }
            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            var transaction = session.BeginTransaction();
            var month = new MonthEnum();
            session.SaveOrUpdate(month.FromETO(eto));

            transaction.Commit();
        }
    }
}

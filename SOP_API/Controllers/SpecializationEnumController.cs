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
    public class SpecializationController : ControllerBase, IBaseController<SpecializationEnumETO>
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
            var entity = session.Get<SpecializationEnum>(ID);
            session.Delete(entity);
            transaction.Commit();
        }

        [HttpGet]
        public IEnumerable<SpecializationEnumETO> Get()
        {
            var role = RoleParser.Parse(HttpContext.Request.Headers["Role"]);
            if (role != SystemRole.Director && role != SystemRole.Registration && role != SystemRole.Admin)
            {
                return Enumerable.Empty<SpecializationEnumETO>();
            }

            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            session.BeginTransaction();
            var specializationEnum = session.Query<SpecializationEnum>();
            var resault = new List<SpecializationEnumETO>();
            foreach (var item in specializationEnum)
            {
                resault.Add(item.ToETO());
            }
            return resault;
        }

        [HttpGet("{ID:int}")]
        public SpecializationEnumETO Get(int ID)
        {
            var role = RoleParser.Parse(HttpContext.Request.Headers["Role"]);
            if (role != SystemRole.Director && role != SystemRole.Registration && role != SystemRole.Admin)
            {
                return null;
            }
            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            session.BeginTransaction();
            var specializationEnum = session.Get<SpecializationEnum>(ID);

            return specializationEnum.ToETO();
        }

        [HttpPost]
        public void Post(SpecializationEnumETO eto)
        {
            var role = RoleParser.Parse(HttpContext.Request.Headers["Role"]);
            if (role != SystemRole.Director && role != SystemRole.Registration && role != SystemRole.Admin)
            {
                return;
            }
            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            var transaction = session.BeginTransaction();
            var roleEnum = new SpecializationEnum();
            session.Save(roleEnum.FromETO(eto));

            transaction.Commit();
        }

        [HttpPut]
        public void Put(SpecializationEnumETO eto)
        {
            var role = RoleParser.Parse(HttpContext.Request.Headers["Role"]);
            if (role != SystemRole.Director && role != SystemRole.Registration && role != SystemRole.Admin)
            {
                return;
            }
            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            var transaction = session.BeginTransaction();
            var roleEnum = new SpecializationEnum();
            session.SaveOrUpdate(roleEnum.FromETO(eto));

            transaction.Commit();
        }
    }
}

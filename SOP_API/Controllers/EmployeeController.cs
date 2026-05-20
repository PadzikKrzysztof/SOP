using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SOP_API.DBClasses.Models;
using SOP_API.DBConnection;
using SOP_ETOLibrary;

namespace SOP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase, IBaseController<EmployeeETO>
    {
        [HttpDelete("{ID:int}")]
        public ActionResult Delete(int ID)
        {
            var role = RoleParser.Parse(HttpContext.Request.Headers["Role"]);
            if (role != SystemRole.Director)
            {
                return BadRequest();
            }

            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            var transaction = session.BeginTransaction();
            var entity = session.Get<Employee>(ID);
            session.Delete(entity);
            transaction.Commit();

            return Ok();
        }

        [HttpGet]
        public ActionResult<IEnumerable<EmployeeETO>> Get()
        {
            var role = RoleParser.Parse(HttpContext.Request.Headers["Role"]);
            if (role != SystemRole.None && role != SystemRole.Doctor && role != SystemRole.Director && role != SystemRole.Admin)
            {
                return BadRequest();
            }

            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            var entities = session.Query<Employee>();
            var etos = new List<EmployeeETO>();
            foreach (var entity in entities)
            {
                var eto = entity.ToETO();
                if (role == SystemRole.None)
                {
                    eto.Name = "";
                    eto.Surname = "";
                    eto.LoginProfile.Password = "";
                    eto.LoginProfile.Login = "";
                }
                etos.Add(eto);
            }

            return Ok(etos);
        }

        [HttpGet("{ID:int}")]
        public ActionResult<EmployeeETO> Get(int ID)
        {
            var role = RoleParser.Parse(HttpContext.Request.Headers["Role"]);
            if (role != SystemRole.Doctor && role != SystemRole.Director && role != SystemRole.Admin)
            {
                return null;
            }

            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            var entity = session.Get<Employee>(ID);

            return Ok(entity.ToETO());
        }

        [HttpPost]
        public ActionResult Post(EmployeeETO eto)
        {
            var role = RoleParser.Parse(HttpContext.Request.Headers["Role"]);
            if (role != SystemRole.Director)
            {
                return BadRequest();
            }

            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            var transaction = session.BeginTransaction();

            var entity = new Employee();
            session.Save(entity.FromETO(eto));
            transaction.Commit();

            return Ok();
        }

        [HttpPut]
        public ActionResult Put(EmployeeETO eto)
        {
            var role = RoleParser.Parse(HttpContext.Request.Headers["Role"]);
            if (role != SystemRole.Doctor && role != SystemRole.Director && role != SystemRole.Admin)
            {
                return BadRequest();
            }

            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            var transaction = session.BeginTransaction();

            var entity = new Employee();
            session.SaveOrUpdate(entity.FromETO(eto));
            transaction.Commit();

            return Ok();
        }
    }
}

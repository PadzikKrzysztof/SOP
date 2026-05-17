using Microsoft.AspNetCore.Mvc;
using SOP_API.DBClasses.Models;
using SOP_API.DBConnection;
using SOP_ETOLibrary;

namespace SOP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase, IBaseController<DoctorETO>
    {
        [HttpDelete("{ID:int}")]
        public void Delete(int ID)
        {
            var role = RoleParser.Parse(HttpContext.Request.Headers["Role"]);
            if (role != SystemRole.Director)
            {
                return;
            }

            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            var transaction = session.BeginTransaction();
            var entity = session.Get<LoginProfile>(ID);
            session.Delete(entity);
            transaction.Commit();
        }

        [HttpGet]
        public IEnumerable<DoctorETO> Get()
        {
            var role = RoleParser.Parse(HttpContext.Request.Headers["Role"]);
            if (role != SystemRole.None && role != SystemRole.Doctor && role != SystemRole.Director && role != SystemRole.Admin)
            {
                return null;
            }

            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            var entities = session.Query<Doctor>();
            var etos = new List<DoctorETO>();
            foreach (var entity in entities)
            {
                var eto = entity.ToETO();
                if (role == SystemRole.None)
                {
                    eto.Employee.Name = "";
                    eto.Employee.Surname = "";
                    eto.Specialization = null;
                    eto.Availabilites = null;
                    eto.Employee.LoginProfile = null;
                }

                etos.Add(eto);
            }

            return etos;
        }

        [HttpGet("{ID:int}")]
        public DoctorETO Get(int ID)
        {
            var role = RoleParser.Parse(HttpContext.Request.Headers["Role"]);
            if (role != SystemRole.Doctor && role != SystemRole.Director && role != SystemRole.Admin)
            {
                return null;
            }

            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            var entity = session.Get<Doctor>(ID);

            return entity.ToETO();
        }

        [HttpPost]
        public void Post(DoctorETO eto)
        {
            var role = RoleParser.Parse(HttpContext.Request.Headers["Role"]);
            if (role != SystemRole.Director)
            {
                return;
            }

            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            var transaction = session.BeginTransaction();

            var entity = new Doctor();
            session.Save(entity.FromETO(eto));
            transaction.Commit();
        }

        [HttpPut]
        public void Put(DoctorETO eto)
        {
            var role = RoleParser.Parse(HttpContext.Request.Headers["Role"]);
            if (role != SystemRole.Doctor && role != SystemRole.Director && role != SystemRole.Admin)
            {
                return;
            }

            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            var transaction = session.BeginTransaction();

            var entity = new Doctor();
            session.SaveOrUpdate(entity.FromETO(eto));
            transaction.Commit();
        }
    }
}

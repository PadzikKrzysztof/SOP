using Microsoft.AspNetCore.Mvc;
using SOP_API.DBClasses.Models;
using SOP_API.DBConnection;
using SOP_ETOLibrary;

namespace SOP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        [HttpGet("{ID:int}")]
        public ActionResult<SystemRole> Get(int ID)
        {
            var role = RoleParser.Parse(HttpContext.Request.Headers["Role"]);
            if (role != SystemRole.LogedIn)
            {
                return role;
            }
            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            var patient = session.Query<Patient>().FirstOrDefault(x => x.LoginProfile.ID == ID);
            if (patient != null)
            {
                return SystemRole.Patient;
            }

            var doctor = session.Query<Doctor>().FirstOrDefault(x => x.Employee.LoginProfile.ID == ID);
            if (doctor != null)
            {
                return SystemRole.Doctor;
            }
            var nonDoctor = session.Query<NonDoctor>().FirstOrDefault(x => x.Employee.LoginProfile.ID == ID);
            if (nonDoctor != null && nonDoctor.Role.Name == "Rejestration")
            {
                return SystemRole.Registration;
            }

            if (nonDoctor != null && nonDoctor.Role.Name == "Administration")
            {
                return SystemRole.Admin;
            }

            if (nonDoctor != null && nonDoctor.Role.Name == "Director")
            {
                return SystemRole.Doctor;
            }

            return Ok(role);
        }
    }
}

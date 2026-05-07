using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SOP_API.DBClasses.Models;
using SOP_API.DBConnection;
using SOP_API.Models;
using System.Numerics;

namespace SOP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<UserModelETO> Get()
        {
            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            session.BeginTransaction();
            var doctors = session.Query<Doctor>();
            var nonDostors = session.Query<NonDoctor>();
            var resault = new List<UserModelETO>();
            foreach (var doctor in doctors)
            {
                resault.Add(new UserModelETO 
                {
                    Id = doctor.ID,
                    Name = doctor.Employee.Name,
                    Surname = doctor.Employee.Surname,
                    Role = "Doctor"
                });
            }
            foreach (var nonDoctor in nonDostors)
            {
                resault.Add(new UserModelETO
                {
                    Id = nonDoctor.ID,
                    Name = nonDoctor.Employee.Name,
                    Surname = nonDoctor.Employee.Surname,
                    Role = nonDoctor.Role.Name
                });
            }
            return resault;
        }
    }
}

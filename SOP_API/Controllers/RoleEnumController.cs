using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NHibernate;
using SOP_API.DBClasses.Models;
using SOP_API.DBConnection;
using SOP_API.Models;
using SOP_ETOLibrary;

namespace SOP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleEnumController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<RoleEnumETO> Get()
        {
            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            session.BeginTransaction();
            var roleEnums = session.Query<RoleEnum>();
            var resault = new List<RoleEnumETO>();
            foreach (var item in roleEnums)
            {
                resault.Add(new RoleEnumETO
                {
                    ID = item.ID,
                    Name = item.Name,
                });
            }
            return resault;
        }

        [HttpPut]
        public void Put(RoleEnumETO element)
        {
            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            var transaction = session.BeginTransaction();
            session.Save(new RoleEnum 
            {
                Name = element.Name
            });
            transaction.Commit();

        }
    }
}

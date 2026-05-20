using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NHibernate;
using SOP_API.DBClasses.Models;
using SOP_API.DBConnection;
using SOP_ETOLibrary;
using System.Net.Http.Headers;
using System.Xml.Linq;

namespace SOP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleEnumController : ControllerBase, IBaseController<RoleEnumETO>
    {
        [HttpDelete("{ID:int}")]
        public ActionResult Delete(int ID)
        {
            var role = RoleParser.Parse(HttpContext.Request.Headers["Role"]);
            if (role != SystemRole.Director && role != SystemRole.Registration && role != SystemRole.Admin)
            {
                return BadRequest();
            }
            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            var transaction = session.BeginTransaction();
            var entity = session.Get<RoleEnum>(ID);
            session.Delete(entity);
            transaction.Commit();

            return Ok();
        }

        [HttpGet]
        public ActionResult<IEnumerable<RoleEnumETO>> Get()
        {
            var role = RoleParser.Parse(HttpContext.Request.Headers["Role"]);
            if (role != SystemRole.Director && role != SystemRole.Registration && role != SystemRole.Admin)
            {
                return BadRequest();
            }
            
            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            session.BeginTransaction();
            var roleEnums = session.Query<RoleEnum>();
            var resault = new List<RoleEnumETO>();
            foreach (var item in roleEnums)
            {
                resault.Add(item.ToETO());
            }

            return Ok(resault);
        }

        [HttpGet("{ID:int}")]
        public ActionResult<RoleEnumETO> Get(int ID)
        {
            var role = RoleParser.Parse(HttpContext.Request.Headers["Role"]);
            if (role != SystemRole.Director && role != SystemRole.Registration && role != SystemRole.Admin)
            {
                return BadRequest();
            }
            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            session.BeginTransaction();
            var roleEnum = session.Get<RoleEnum>(ID);

            return Ok(roleEnum.ToETO());
        }

        [HttpPost]
        public ActionResult Post(RoleEnumETO eto)
        {
            var role = RoleParser.Parse(HttpContext.Request.Headers["Role"]);
            if (role != SystemRole.Director && role != SystemRole.Registration && role != SystemRole.Admin)
            {
                return BadRequest();
            }
            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            var transaction = session.BeginTransaction();
            var roleEnum = new RoleEnum();
            session.Save(roleEnum.FromETO(eto));

            transaction.Commit();
            return Ok();
        }

        [HttpPut]
        public ActionResult Put(RoleEnumETO eto)
        {
            var role = RoleParser.Parse(HttpContext.Request.Headers["Role"]);
            if (role != SystemRole.Director && role != SystemRole.Registration && role != SystemRole.Admin)
            {
                return BadRequest();
            }
            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            var transaction = session.BeginTransaction();
            var roleEnum = new RoleEnum();
            session.SaveOrUpdate(roleEnum.FromETO(eto));

            transaction.Commit();

            return Ok();
        }
    }
}

using FluentNHibernate.Data;
using Microsoft.AspNetCore.Mvc;
using SOP_API.DBClasses.Models;
using SOP_API.DBConnection;
using SOP_ETOLibrary;

namespace SOP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginProfileController : Controller, IBaseController<LoginProfileETO>
    {
        [HttpDelete("{ID:int}")]
        public ActionResult Delete(int ID)
        {
            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            var transaction = session.BeginTransaction();
            var entity = session.Get<LoginProfile>(ID);
            session.Delete(entity);
            transaction.Commit();

            return Ok();
        }

        [HttpGet]
        public ActionResult<IEnumerable<LoginProfileETO>> Get()
        {
            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            var entities = session.Query<LoginProfile>();
            var etos = new List<LoginProfileETO>();
            foreach (var entity in entities)
            {
                etos.Add(entity.ToETO());
            }

            return etos;
        }

        [HttpGet("{ID:int}")]
        public ActionResult<LoginProfileETO> Get(int ID)
        {
            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            var entity = session.Get<LoginProfile>(ID);

            return Ok(entity.ToETO());
        }

        [HttpPost]
        public ActionResult Post(LoginProfileETO eto)
        {
            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            var transaction = session.BeginTransaction();

            var entity = new LoginProfile();
            session.Save(entity.FromETO(eto));
            transaction.Commit();

            return Ok();
        }

        [HttpPut]
        public ActionResult Put(LoginProfileETO eto)
        {
            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            var transaction = session.BeginTransaction();

            var entity = new LoginProfile();
            session.SaveOrUpdate(entity.FromETO(eto));
            transaction.Commit();

            return Ok();
        }
    }
}

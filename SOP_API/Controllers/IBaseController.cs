using Microsoft.AspNetCore.Mvc;

namespace SOP_API.Controllers
{
    public interface IBaseController<IETO>
    {
        public ActionResult<IEnumerable<IETO>> Get();
        public ActionResult<IETO> Get(int ID);
        public ActionResult Post(IETO eto);

        public ActionResult Put(IETO eto);
        public ActionResult Delete(int ID);
    }
}

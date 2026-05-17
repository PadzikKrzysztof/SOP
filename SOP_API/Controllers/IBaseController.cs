namespace SOP_API.Controllers
{
    public interface IBaseController<IETO>
    {
        public IEnumerable<IETO> Get();
        public IETO Get(int ID);
        public void Post(IETO eto);

        public void Put(IETO eto);
        public void Delete(int ID);
    }
}

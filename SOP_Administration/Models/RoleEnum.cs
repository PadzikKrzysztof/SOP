using SOP_Administration.HttpConnection;
using SOP_ETOLibrary;

namespace SOP_Administration.Models
{
    public partial class RoleEnum : RoleEnumETO
    {
        private static string _url = "api/RoleEnum";
        public static List<RoleEnumETO> GetList()
            => HttpHandler.GetList<RoleEnumETO>(_url);

        public static RoleEnumETO Get(int ID)
            => HttpHandler.Get<RoleEnumETO>(ID, _url);

        public static void Put(RoleEnumETO eto)
        {
            HttpHandler.Put(eto, _url);
        }
        public static void Post(RoleEnumETO eto)
        {
            HttpHandler.Post(eto, _url);
        }

        public static void Delete(int ID)
        {
            HttpHandler.Delete<RoleEnumETO>(ID, _url);
        }
    }
}

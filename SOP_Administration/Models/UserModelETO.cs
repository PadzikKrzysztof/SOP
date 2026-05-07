using SOP_Administration.HttpConnection;
using SOP_ETOLibrary;

namespace SOP_API.Models
{
    public partial class UserModel : UserModelETO
    {
        private static string _url = "api/UserModel";
        public static List<UserModelETO> GetList()
            => HttpHandler.GetList<UserModelETO>(_url);

        public static void Put(UserModelETO eto)
        {
            HttpHandler.Put(eto, _url);
        }
    }
}

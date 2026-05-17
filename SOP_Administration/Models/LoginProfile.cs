using SOP_Administration.HttpConnection;
using SOP_ETOLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOP_Administration.Models
{
    public class LoginProfile : LoginProfileETO
    {
        private static string _url = "api/LoginProfile";
        public static List<LoginProfileETO> GetList()
            => HttpHandler.GetList<LoginProfileETO>(_url);

        public static LoginProfileETO Get(int ID)
            => HttpHandler.Get<LoginProfileETO>(ID, _url);

        public static void Put(LoginProfileETO eto)
        {
            HttpHandler.Put(eto, _url);
        }
        public static void Post(LoginProfileETO eto)
        {
            HttpHandler.Post(eto, _url);
        }

        public static void Delete(int ID)
        {
            HttpHandler.Delete<LoginProfileETO>(ID, _url);
        }
    }
}

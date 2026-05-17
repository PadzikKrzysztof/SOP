using SOP_Administration.HttpConnection;
using SOP_ETOLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOP_Administration.Models
{
    public class SlecializationEnum : SpecializationEnumETO
    {
        private static string _url = "api/SpecializationEnum";
        public static List<SpecializationEnumETO> GetList()
            => HttpHandler.GetList<SpecializationEnumETO>(_url);

        public static SpecializationEnumETO Get(int ID)
            => HttpHandler.Get<SpecializationEnumETO>(ID, _url);

        public static void Put(SpecializationEnumETO eto)
        {
            HttpHandler.Put(eto, _url);
        }
        public static void Post(SpecializationEnumETO eto)
        {
            HttpHandler.Post(eto, _url);
        }

        public static void Delete(int ID)
        {
            HttpHandler.Delete<SpecializationEnumETO>(ID, _url);
        }
    }
}

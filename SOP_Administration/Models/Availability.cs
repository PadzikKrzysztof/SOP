using SOP_Administration.HttpConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOP_ETOLibrary;

namespace SOP_Administration.Models
{
    public partial class Availability : AvailabilityETO
    {
        private static string _url = "api/Availability";
        public static List<AvailabilityETO> GetList()
            => HttpHandler.GetList<AvailabilityETO>(_url);

        public static void Put(AvailabilityETO eto)
        {
            HttpHandler.Put(eto, _url);
        }
    }
}

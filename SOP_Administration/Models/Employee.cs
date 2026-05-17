using SOP_Administration.HttpConnection;
using SOP_ETOLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOP_Administration.Models
{
    public class Employee : EmployeeETO
    {
        private static string _url = "api/Employee";
        public static List<EmployeeETO> GetList()
            => HttpHandler.GetList<EmployeeETO>(_url);

        public static EmployeeETO Get(int ID)
            => HttpHandler.Get<EmployeeETO>(ID, _url);

        public static void Put(EmployeeETO eto)
        {
            HttpHandler.Put(eto, _url);
        }
        public static void Post(EmployeeETO eto)
        {
            HttpHandler.Post(eto, _url);
        }

        public static void Delete(int ID)
        {
            HttpHandler.Delete<EmployeeETO>(ID, _url);
        }
    }
}

using SOP_API.Models;
using SOP_ETOLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace SOP_Administration.HttpConnection
{
    public class HttpHandler
    {
        private static HttpClient _httpClient { get; set; }
        public static void Create()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:5227")
            };
        }

        public static List<T> GetList<T>(string url)
        {
            var responce = _httpClient.GetAsync(url).Result;
            return responce.Content.ReadFromJsonAsync<List<T>>().Result;
        }

        public static void Put<T>(T eto, string url)
        {
            _httpClient.PutAsJsonAsync(url, eto);
        }
    }
}

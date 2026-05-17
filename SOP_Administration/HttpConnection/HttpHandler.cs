using SOP_ETOLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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

        public static void Authorize(SystemRole role)
        {
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("Role", ((int)role).ToString());
        }

        public static T Get<T>(int ID, string url)
        {
            url += $"/{ID}";
            var responce = _httpClient.GetAsync(url).Result;
            return responce.Content.ReadFromJsonAsync<T>().Result;
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
        public static void Post<T>(T eto, string url)
        {
            _httpClient.PostAsJsonAsync(url, eto);
        }
        public static void Delete<T>(int ID, string url)
        {
            url += $"/{ID}";
            _httpClient.DeleteAsync(url);
        }

        public static SystemRole GetRole(int ID)
        {
            var url = $"api/Login/{ID}";
            var responce = _httpClient.GetAsync(url).Result;
            return (SystemRole)int.Parse(responce.Content.ReadAsStringAsync().Result);
        }
    }
}

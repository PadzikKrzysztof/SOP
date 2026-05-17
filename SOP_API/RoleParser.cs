using SOP_ETOLibrary;
using System.Net.Http;

namespace SOP_API
{
    public class RoleParser
    {
        public static SystemRole Parse(string role)
            => (SystemRole)int.Parse(role);
    }
}

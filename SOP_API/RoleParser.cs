using SOP_ETOLibrary;
using System.Net.Http;

namespace SOP_API
{
    public class RoleParser
    {
        public static SystemRole Parse(string role)
        {
            if (string.IsNullOrEmpty(role))
            {
                return SystemRole.None;
            }
            else
            {
                return (SystemRole)int.Parse(role);
            }
        }
    }
}

using SOP_ETOLibrary;

namespace SOP_API.Models
{
    public partial class UserModelETO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Role { get; set; }
    }
}

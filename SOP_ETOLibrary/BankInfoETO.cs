using System.Numerics;

namespace SOP_ETOLibrary
{
    public partial class BankInfoETO : IETO
    {
        public int ID { get; set; }
        public string BankDetails { get; set; }
        public string Name { get; set; }
    }
}

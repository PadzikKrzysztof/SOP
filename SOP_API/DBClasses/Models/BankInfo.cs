using System.Numerics;

namespace SOP_API.DBClasses.Models
{
    public class BankInfo
    {
        private int _ID;
        private string _bankDetails;
        private string _name;

        public virtual int ID { get => _ID; set => _ID = value; }
        public virtual string BankDetails { get => _bankDetails; set => _bankDetails = value; }
        public virtual string Name { get => _name; set => _name = value; }
    }
}

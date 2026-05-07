namespace SOP_API.DBClasses.Models
{
    public class PaymentInfo
    {
        private int _ID;
        private string _addres;
        private int _bankNumber;
        private BankInfo _bankInfo;

        public virtual int ID { get => _ID; set => _ID = value; }
        public virtual string Addres { get => _addres; set => _addres = value; }
        public virtual int BankNumber { get => _bankNumber; set => _bankNumber = value; }
        public virtual BankInfo BankInfo { get => _bankInfo; set => _bankInfo = value; }
    }
}

namespace SOP_API.DBClasses.Models
{
    public class Employee
    {
        private int _ID;
        private string _name;
        private string _surname;
        private PaymentInfo _paymentInfo;

        public virtual int ID { get => _ID; set => _ID = value; }
        public virtual string Name { get => _name; set => _name = value; }
        public virtual string Surname { get => _surname; set => _surname = value; }
        public virtual PaymentInfo PaymentInfo { get => _paymentInfo; set => _paymentInfo = value; }
    }
}

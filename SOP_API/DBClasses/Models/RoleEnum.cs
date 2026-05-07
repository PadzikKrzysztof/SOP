namespace SOP_API.DBClasses.Models
{
    public class RoleEnum
    {
        private int _ID;
        private string _name;
        public virtual int ID { get => _ID; set => _ID = value; }
        public virtual string Name { get => _name; set => _name = value; }
    }
}

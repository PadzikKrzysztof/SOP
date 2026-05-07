using System.Security.Cryptography;

namespace SOP_API.DBClasses.Models
{
    public class FileNote
    {
        private int _ID;
        private string _name;
        private string _descriptio;
        private LabTest _labTest;

        public virtual int ID { get => _ID; set => _ID = value; }
        public virtual string Name { get => _name; set => _name = value; }
        public virtual string Description { get => _descriptio; set => _descriptio = value; }
        public virtual LabTest LabTest { get => _labTest; set => _labTest = value; }
    }
}

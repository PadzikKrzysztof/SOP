namespace SOP_API.DBClasses.Models
{
    public class PatientFile
    {
        private int _ID;
        private string _name;
        private string _description;
        private IList<LabTest> _labTests;
        private Patient _patient;

        public virtual int ID { get => _ID; set => _ID = value; }
        public virtual string Name { get => _name; set => _name = value; }
        public virtual string Description { get => _description; set => _description = value; }
        public virtual IList<LabTest> LabTests { get => _labTests; set => _labTests = value; }
        public virtual Patient Patient { get => _patient; set => _patient = value; }
    }
}

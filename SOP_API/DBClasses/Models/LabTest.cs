namespace SOP_API.DBClasses.Models
{
    public class LabTest
    {
        private int _ID;
        private string _name;
        private string _description;
        private string _specificData;
        private PatientFile _patientFile;

        public virtual int ID { get => _ID; set => _ID = value; }
        public virtual string Name { get => _name; set => _name = value; }
        public virtual string Description { get => _description; set => _description = value; }
        public virtual string SpecificData { get => _specificData; set => _specificData = value; }
        public virtual PatientFile PatientFile { get => _patientFile; set => _patientFile = value; }
    }
}

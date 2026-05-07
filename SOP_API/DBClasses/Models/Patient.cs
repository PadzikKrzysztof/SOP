namespace SOP_API.DBClasses.Models
{
    public class Patient
    {
        private int _ID;
        private string _name;
        private string _surname;
        private int _PESEL;
        private List<PatientFile> _patientFiles;

        public virtual int ID { get => _ID; set => _ID = value; }
        public virtual string Name { get => _name; set => _name = value; }
        public virtual string Surname { get => _surname; set => _surname = value; }
        public virtual int PESEL { get => _PESEL; set => _PESEL = value; }
        public virtual List<PatientFile> PatientFiles { get => _patientFiles; set => _patientFiles = value; }
    }
}

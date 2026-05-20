using SOP_ETOLibrary;
using System.Data;

namespace SOP_API.DBClasses.Models
{
    public class Patient
    {
        private int _ID;
        private string _name;
        private string _surname;
        private long _PESEL;
        private string _email;
        private long _phoneNumber;
        private IList<PatientFile> _patientFiles;
        private LoginProfile _loginProfile;

        public virtual int ID { get => _ID; set => _ID = value; }
        public virtual string Name { get => _name; set => _name = value; }
        public virtual string Surname { get => _surname; set => _surname = value; }
        public virtual long PESEL { get => _PESEL; set => _PESEL = value; }
        public virtual string Email { get => _email; set => _email = value; }
        public virtual long PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        public virtual IList<PatientFile> PatientFiles { get => _patientFiles; set => _patientFiles = value; }
        public virtual LoginProfile LoginProfile { get => _loginProfile; set => _loginProfile = value; }
        
        public virtual PatientETO ToETO()

        {
            var patientFileETOs = new List<PatientFileETO>();
            foreach (var item in PatientFiles)
            {
                patientFileETOs.Add(item.ToETO());
            }

            return new PatientETO
            {
                ID = ID,
                Name = Name,
                Surname = Surname,
                PESEL = PESEL,
                Email = Email,
                PhoneNumber = PhoneNumber,
                PatientFiles = patientFileETOs,
                LoginProfile = LoginProfile.ToETO(),
            };
        }

        public virtual Patient FromETO(PatientETO eto)
        {
            var patientFiles = new List<PatientFile>();

            foreach (var item in eto.PatientFiles)
            {
                var av = new PatientFile();
                patientFiles.Add(av.FromETO(item));
            }

            LoginProfile = new LoginProfile();

            return new Patient
            {
                ID = eto.ID,
                Name = eto.Name,
                Surname = eto.Surname,
                PESEL = eto.PESEL,
                Email = eto.Email,
                PhoneNumber = eto.PhoneNumber,
                PatientFiles = patientFiles,
                LoginProfile = LoginProfile.FromETO(eto.LoginProfile),
            };
        }
    }
}

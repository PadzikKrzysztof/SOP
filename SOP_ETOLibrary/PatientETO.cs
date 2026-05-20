namespace SOP_ETOLibrary
{
    public partial class PatientETO : IETO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public long PESEL { get; set; }
        public string Email { get; set; }
        public long PhoneNumber { get; set; }
        public List<PatientFileETO> PatientFiles { get; set; }
        public LoginProfileETO LoginProfile { get; set; }
    }
}

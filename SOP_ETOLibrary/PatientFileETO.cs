namespace SOP_ETOLibrary
{
    public partial class PatientFileETO : IETO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<LabTestETO> LabTests { get; set; } = new List<LabTestETO>();
        public List<VisitETO> Visits { get; set; } = new List<VisitETO>();
    }
}
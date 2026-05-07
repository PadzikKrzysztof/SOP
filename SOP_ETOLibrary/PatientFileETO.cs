namespace SOP_ETOLibrary
{
    public partial class PatientFileETO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<LabTestETO> LabTests { get; set; }
        public PatientETO patient { get; set; }
    }
}
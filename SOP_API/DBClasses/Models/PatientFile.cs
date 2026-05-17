using SOP_ETOLibrary;
using System.ComponentModel;
using static Antlr.Runtime.Tree.TreeWizard;

namespace SOP_API.DBClasses.Models
{
    public class PatientFile
    {
        private int _ID;
        private string _name;
        private string _description;
        private IList<LabTest> _labTests = new List<LabTest>();
        private IList<Visit> _visits = new List<Visit>();

        public virtual int ID { get => _ID; set => _ID = value; }
        public virtual string Name { get => _name; set => _name = value; }
        public virtual string Description { get => _description; set => _description = value; }
        public virtual IList<LabTest> LabTests { get => _labTests; set => _labTests = value; } 
        public virtual IList<Visit> Visits { get => _visits; set => _visits = value; }
        public virtual PatientFileETO ToETO()
        {
            var labTestETOs = new List<LabTestETO>();
            foreach (var item in LabTests)
            {
                labTestETOs.Add(item.ToETO());
            }

            var visitETOs = new List<VisitETO>();
            foreach (var item in Visits)
            {
                visitETOs.Add(item.ToETO());
            }

            return new PatientFileETO
            {
                ID = ID,
                Name = Name,
                Description = Description,
                LabTests = labTestETOs,
                Visits = visitETOs,
            };
        }

        public virtual PatientFile FromETO(PatientFileETO eto)
        {
            var labTests = new List<LabTest>();

            foreach (var item in eto.LabTests)
            {
                var av = new LabTest();
                labTests.Add(av.FromETO(item));
            }

            var visits = new List<Visit>();

            foreach (var item in eto.Visits)
            {
                var av = new Visit();
                visits.Add(av.FromETO(item));
            }

            return new PatientFile
            {
                ID = eto.ID,
                Name = eto.Name,
                Description = eto.Description,
                LabTests = labTests,
                Visits = visits,
            };
        }
    }
}

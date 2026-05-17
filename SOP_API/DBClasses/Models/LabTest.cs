using SOP_ETOLibrary;

namespace SOP_API.DBClasses.Models
{
    public class LabTest
    {
        private int _ID;
        private string _name;
        private string _description;
        private string _specificData;

        public virtual int ID { get => _ID; set => _ID = value; }
        public virtual string Name { get => _name; set => _name = value; }
        public virtual string Description { get => _description; set => _description = value; }
        public virtual string SpecificData { get => _specificData; set => _specificData = value; }
        public virtual LabTestETO ToETO()
        {
            return new LabTestETO
            {
                ID = ID,
                Name = Name,
                Description = Description,
                SpecificData = SpecificData
            };
        }

        public virtual LabTest FromETO(LabTestETO eto)
        {
            return new LabTest
            {
                ID = eto.ID,
                Name = eto.Name,
                Description = eto.Description,
                SpecificData = eto.SpecificData,
            };
        }
    }
}

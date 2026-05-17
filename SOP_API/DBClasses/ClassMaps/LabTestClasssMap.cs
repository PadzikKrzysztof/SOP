using FluentNHibernate.Mapping;
using SOP_API.DBClasses.Models;

namespace SOP_API.DBClasses.ClassMaps
{
    public class LabTestClasssMap: ClassMap<LabTest>
    {
        public LabTestClasssMap()
        {
            Id(x => x.ID);
            Map(x => x.Name);
            Map(x => x.Description);
            Map(x => x.SpecificData);
            Table("LabTest");
        }
    }
}

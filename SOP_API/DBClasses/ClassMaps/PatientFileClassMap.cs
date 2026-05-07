using FluentNHibernate.Mapping;
using SOP_API.DBClasses.Models;

namespace SOP_API.DBClasses.ClassMaps
{
    public class PatientFileClassMap : ClassMap<PatientFile>
    {
        public PatientFileClassMap()
        {
            Id(x => x.ID);
            Map(x => x.Name);
            Map(x => x.Description);
            HasMany(x => x.LabTests).Table("LabTest");
            References(x => x.Patient).Column("PatientID").LazyLoad();
            Table("PatientFile");
        }
    }
}

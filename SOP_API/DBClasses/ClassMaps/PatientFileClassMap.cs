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
            HasMany(x => x.LabTests).Table("LabTest").KeyColumn("PatientFileID").Cascade.SaveUpdate();
            HasMany(x => x.Visits).Table("Visit").KeyColumn("PatientFileID").Cascade.SaveUpdate();
            Table("PatientFile");
        }
    }
}

using FluentNHibernate.Mapping;
using SOP_API.DBClasses.Models;

namespace SOP_API.DBClasses.ClassMaps
{
    public class PatientClassMap : ClassMap<Patient>
    {
        public PatientClassMap()
        {
            Id(x => x.ID);
            Map(x => x.Name);
            Map(x => x.Surname);
            Map(x => x.PESEL);
            Map(x => x.Email);
            Map(x => x.PhoneNumber);
            HasMany(x => x.PatientFiles).Table("PatientFile").KeyColumn("PatientID").Cascade.SaveUpdate();
            References(x => x.LoginProfile).Column("LoginProfileID");
            Table("Patient");
        }
    }
}

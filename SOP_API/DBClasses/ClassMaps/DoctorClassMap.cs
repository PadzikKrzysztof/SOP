using FluentNHibernate.Mapping;
using SOP_API.DBClasses.Models;

namespace SOP_API.DBClasses.ClassMaps
{
    public class DoctorClassMap : ClassMap<Doctor>
    {
        public DoctorClassMap()
        {
            Id(x => x.ID);
            References(x => x.Specialization).Column("Specialization");
            References(x => x.Employee).Column("EmployeeID").Cascade.SaveUpdate();
            HasMany(x => x.Availabilites).Table("Availability").KeyColumn("DoctorID");
            Table("Doctor");
        }
    }
}

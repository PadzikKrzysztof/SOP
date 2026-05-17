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
            References(x => x.Employee).Column("EmployeeID");
            HasMany(x => x.Availabilites).Table("Availability").KeyColumn("DoctorID").Cascade.SaveUpdate();
            Table("Doctor");
        }
    }
}

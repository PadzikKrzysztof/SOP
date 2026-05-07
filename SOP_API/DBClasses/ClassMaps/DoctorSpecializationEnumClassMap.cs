using FluentNHibernate.Mapping;
using SOP_API.DBClasses.Models;

namespace SOP_API.DBClasses.ClassMaps
{
    public class DoctorSpecializationEnumClassMap : ClassMap<DoctorSpecializationEnum>
    {
        public DoctorSpecializationEnumClassMap()
        {
            Id(x => x.ID);
            Map(x => x.Name);
            Table("DoctorSpecializationEnum");
        }
    }
}

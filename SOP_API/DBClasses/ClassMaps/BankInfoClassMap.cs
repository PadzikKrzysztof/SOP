using FluentNHibernate.Mapping;
using SOP_API.DBClasses.Models;

namespace SOP_API.DBClasses.ClassMaps
{
    public class BankInfoClassMap : ClassMap<BankInfo>
    {
        public BankInfoClassMap()
        {
            Id(x => x.ID);
            Map(x => x.BankDetails);
            Map(x => x.Name);
            Table("BankInfo");
        }
    }
}

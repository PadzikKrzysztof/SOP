using FluentNHibernate.Mapping;
using SOP_API.DBClasses.Models;
using System.Security.Cryptography.Xml;

namespace SOP_API.DBClasses.ClassMaps
{
    public class PaymentInfoClassMap : ClassMap<PaymentInfo>
    {
        public PaymentInfoClassMap()
        {
            Id(x => x.ID);
            Map(x => x.Addres).Column("Addres");
            Map(x => x.BankNumber).Column("BankNumber");
            References(x => x.BankInfo).Column("BankInfoID");
            Table("PaymentInfo");
        }
    }
}

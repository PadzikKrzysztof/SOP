using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SOP_API.DBClasses.Models;
using SOP_API.DBConnection;
using SOP_ETOLibrary;

namespace SOP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NonDoctorController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<NonDoctorETO> Get()
        {
            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            session.BeginTransaction();
            var nonDoctors = session.Query<NonDoctor>();
            var resault = new List<NonDoctorETO>();
            foreach (var item in nonDoctors)
            {
                resault.Add(new NonDoctorETO
                {
                    ID = item.ID,
                    Role = item.Role.Name,
                    Name = item.Employee.Name,
                    Surname = item.Employee.Surname,
                    Addres = item.Employee.PaymentInfo.Addres,
                    BankNumber = item.Employee.PaymentInfo.BankNumber,
                    BankName = item.Employee.PaymentInfo.BankInfo.Name,
                    BankDetails = item.Employee.PaymentInfo.BankInfo.BankDetails
                });
            }
            return resault;
        }

        [HttpPut]
        public void Put(NonDoctorETO eto)
        {
            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            var transaction = session.BeginTransaction();
            var bank = session.Query<BankInfo>().FirstOrDefault(x => x.Name == eto.BankName);
            var role = session.Query<RoleEnum>().FirstOrDefault(x => x.Name == eto.Role);
            if (bank == null || role == null)
            {
                return;
            }

            var paymentInfo = new PaymentInfo
            {
                Addres = eto.Addres,
                BankNumber = eto.BankNumber,
                BankInfo = bank
            };

            session.Save(paymentInfo);

            var employee = new Employee
            {
                Name = eto.Name,
                Surname = eto.Surname,
                PaymentInfo = paymentInfo
            };

            session.Save(employee);

            var nonDoctor = new NonDoctor
            {
                Role = role,
                Employee = employee
            };

            session.Save(nonDoctor);
            transaction.Commit();
        }
    }
}

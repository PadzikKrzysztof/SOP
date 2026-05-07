using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SOP_API.DBClasses.Models;
using SOP_API.DBConnection;
using SOP_ETOLibrary;

namespace SOP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<DoctorETO> Get()
        {
            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            session.BeginTransaction();
            var doctors = session.Query<Doctor>();
            var resault = new List<DoctorETO>();
            foreach (var item in doctors)
            {
                var availabilites = session.Query<Availability>().Where(x => x.Doctor.ID == item.ID);
                var availabilityETOs = new List<AvailabilityETO>();
                foreach (var availability in availabilites)
                {
                    availabilityETOs.Add(new AvailabilityETO 
                    {
                        ID = item.ID,
                        TimeStart = availability.TimeStart,
                        TimeEnd = availability.TimeEnd,
                        Day = new DayETO 
                        {
                            ID = availability.Day.ID,
                            DayOfMonth = availability.Day.DayOfMonth,
                            Month = new MonthETO
                            {
                                ID = availability.Day.Month.ID,
                                Name = availability.Day.Month.Name,
                            },
                            Year = availability.Day.Year,
                        }
                    });
                }

                resault.Add(new DoctorETO
                {
                    ID = item.ID,
                    Specialization = item.Specialization.Name,
                    Name = item.Employee.Name,
                    Surname = item.Employee.Surname,
                    Addres = item.Employee.PaymentInfo.Addres,
                    BankNumber = item.Employee.PaymentInfo.BankNumber,
                    BankName = item.Employee.PaymentInfo.BankInfo.Name,
                    BankDetails = item.Employee.PaymentInfo.BankInfo.BankDetails,
                    Availabilites = availabilityETOs
                });
            }
            return resault;
        }

        [HttpPut]
        public void Put(DoctorETO eto)
        {
            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            var transaction = session.BeginTransaction();
            var bank = session.Query<BankInfo>().FirstOrDefault(x => x.Name == eto.BankName);
            var specialization = session.Query<DoctorSpecializationEnum>().FirstOrDefault(x => x.Name == eto.Specialization);
            if (bank == null || specialization == null)
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

            var doctor = new Doctor
            {
                Specialization = specialization,
                Employee = employee
            };

            session.Save(doctor);
            transaction.Commit();
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SOP_API.DBClasses.Models;
using SOP_API.DBConnection;
using SOP_ETOLibrary;

namespace SOP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvailabilityController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<AvailabilityETO> Get()
        {
            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            session.BeginTransaction();
            var availabilites = session.Query<Availability>();
            var availabilityETOs = new List<AvailabilityETO>();
            foreach (var availability in availabilites)
            {
                availabilityETOs.Add(new AvailabilityETO
                {
                    ID = availability.ID,
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

            return availabilityETOs;
        }

        [HttpPut]
        public void Put(AvailabilityETO eto)
        {
            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            var transaction = session.BeginTransaction();
            var day = session.Query<Day>()
                .FirstOrDefault(
                x => 
                x.DayOfMonth == eto.Day.DayOfMonth && 
                x.Month.Name == eto.Day.Month.Name &&
                x.Year == eto.Day.Year);
            if (day == null)
            {
                day = new Day 
                {
                    DayOfMonth = eto.Day.DayOfMonth,
                    Month = session.Query<MonthEnum>().First(x => x.ID == eto.Day.Month.ID),
                    Year = eto.Day.Year
                };
            }

            var availability = new Availability 
            {
                TimeStart = eto.TimeStart,
                TimeEnd = eto.TimeEnd,
                Doctor = session.Query<Doctor>().First(x => x.ID == eto.DoctorId),
                Day = day,
            };

            session.Save(availability);
            transaction.Commit();
        }
    }
}

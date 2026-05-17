using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SOP_API.DBClasses.Models;
using SOP_API.DBConnection;
using SOP_ETOLibrary;

namespace SOP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase, IBaseController<PatientETO>
    {
        [HttpDelete("{ID:int}")]
        public void Delete(int ID)
        {
            var role = RoleParser.Parse(HttpContext.Request.Headers["Role"]);
            if (role != SystemRole.Director && role != SystemRole.Registration && role != SystemRole.Admin)
            {
                return;
            }
            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            var transaction = session.BeginTransaction();
            var entity = session.Get<Patient>(ID);
            session.Delete(entity);
            transaction.Commit();
            session.Close();
        }

        [HttpGet]
        public IEnumerable<PatientETO> Get()
        {
            var role = RoleParser.Parse(HttpContext.Request.Headers["Role"]);

            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            var entities = session.Query<Patient>();
            var ETOs = new List<PatientETO>();
            foreach (var entity in entities)
            {
                var eto = entity.ToETO();
                switch (role)
                {
                    case SystemRole.None:
                        eto.Name = "";
                        eto.Surname = "";
                        eto.PESEL = 0;
                        eto.LoginProfile.Password = string.Empty;
                        eto.LoginProfile.Login = string.Empty;
                        eto.PatientFiles = new List<PatientFileETO>();
                        break;
                    case SystemRole.Patient:
                        foreach (var file in eto.PatientFiles)
                        {
                            foreach (var visit in file.Visits)
                            {
                                visit.Doctor.Availabilites = new List<AvailabilityETO>();
                            }
                        }
                        break;
                    case SystemRole.Doctor:
                    case SystemRole.Director:
                    case SystemRole.Registration:
                    case SystemRole.Admin:
                    default:
                        break;
                }

                ETOs.Add(eto);
            }

            session.Close();
            return ETOs;
        }

        [HttpGet("{ID:int}")]
        public PatientETO Get(int ID)
        {
            var role = RoleParser.Parse(HttpContext.Request.Headers["Role"]);
            if (role != SystemRole.Director && role != SystemRole.Registration && role != SystemRole.Admin)
            {
                return null;
            }
            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            var entity = session.Get<Patient>(ID);
            var eto = entity.ToETO();
            switch (role)
            {
                case SystemRole.None:
                    eto.Name = "";
                    eto.Surname = "";
                    eto.PESEL = 0;
                    eto.LoginProfile.Password = string.Empty;
                    eto.LoginProfile.Login = string.Empty;
                    eto.PatientFiles = new List<PatientFileETO>();
                    break;
                case SystemRole.Patient:
                    foreach (var file in eto.PatientFiles)
                    {
                        foreach (var visit in file.Visits)
                        {
                            visit.Doctor.Availabilites = new List<AvailabilityETO>();
                        }
                    }
                    break;
                case SystemRole.Doctor:
                case SystemRole.Director:
                case SystemRole.Registration:
                case SystemRole.Admin:
                default:
                    break;
            }
            session.Close();
            return eto;
        }

        [HttpPost]
        public void Post(PatientETO eto)
        {
            var role = RoleParser.Parse(HttpContext.Request.Headers["Role"]);
            if (role != SystemRole.Director && role != SystemRole.Registration && role != SystemRole.Admin)
            {
                return;
            }
            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            var transaction = session.BeginTransaction();

            var entity = new Patient();
            session.Save(entity.FromETO(eto));
            transaction.Commit();
            session.Close();
        }

        [HttpPut]
        public void Put(PatientETO eto)
        {
            var role = RoleParser.Parse(HttpContext.Request.Headers["Role"]);
            if (role != SystemRole.Director && role != SystemRole.Registration && role != SystemRole.Admin)
            {
                return;
            }
            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            var transaction = session.BeginTransaction();

            var patient = new Patient();
            //foreach (var file in eto.PatientFiles)
            //{
            //    foreach (var labTest in file.LabTests)
            //    {
            //        var labTestEntity = new LabTest().FromETO(labTest);
            //        //session.Clear();
            //        session.Merge(labTestEntity);
            //        session.SaveOrUpdate(labTestEntity);
            //    }

            //    foreach (var visit in file.Visits)
            //    {
            //        var visitEntity = new Visit().FromETO(visit);
            //        var doctorEntity = new Doctor().FromETO(visit.Doctor);
            //        //session.Clear();
            //        session.Merge(doctorEntity);
            //        session.SaveOrUpdate(doctorEntity);
            //        session.Merge(visitEntity);
            //        session.SaveOrUpdate(visitEntity);
            //    }

            //    //session.Clear();
            //    var patientFile = new PatientFile().FromETO(file);
            //    session.SaveOrUpdate(patientFile);
            //}

            //session.Clear();
            session.SaveOrUpdate(patient.FromETO(eto));
            transaction.Commit();
            session.Close();
        }
    }
}

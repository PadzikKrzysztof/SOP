using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SOP_API.DBClasses.Models;
using SOP_API.DBConnection;
using SOP_ETOLibrary;

namespace SOP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<PatientETO> Get()
        {
            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            session.BeginTransaction();
            var patients = session.Query<Patient>();
            var patientETOs = new List<PatientETO>();
            foreach (var patient in patients)
            {
                var patientFiles = session.Query<PatientFile>().Where(x => x.Patient.ID == patient.ID);
                var patientFileETOs = new List<PatientFileETO>();
                foreach (var patientFile in patientFiles)
                {
                    var labTests = session.Query<LabTest>().Where(x => x.PatientFile.ID == patientFile.ID);
                    var labTestETOs = new List<LabTestETO>();
                    foreach (var labTest in labTests)
                    {
                        labTestETOs.Add(new LabTestETO 
                        { 
                            ID = labTest.ID,
                            Name = labTest.Name,
                            Description = labTest.Description,
                            SpecificData = labTest.SpecificData,
                        });
                    }
                    patientFileETOs.Add(new PatientFileETO 
                    {
                        ID = patientFile.ID,
                        Name = patientFile.Name,
                        Description = patientFile.Description,
                        LabTests = labTestETOs
                    });

                }
                patientETOs.Add(new PatientETO
                {
                    ID = patient.ID,
                    Name = patient.Name,
                    Surname = patient.Surname,
                    PESEL = patient.PESEL,
                    PatientFiles = patientFileETOs
                });
            }

            return patientETOs;
        }

        [HttpPut]
        public void Put(PatientETO eto)
        {
            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            var transaction = session.BeginTransaction();

            var patient = new Patient
            {
                Name = eto.Name,
                Surname = eto.Surname,
                PESEL = eto.PESEL
            };

            session.Save(patient);
            transaction.Commit();
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SOP_API.DBClasses.Models;
using SOP_API.DBConnection;
using SOP_ETOLibrary;

namespace SOP_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PatientFileController : ControllerBase
    {
        [HttpGet("{ID}")]
        [ActionName("ByPatientId")]
        public IEnumerable<PatientFileETO> Get(int ID)
        {
            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            session.BeginTransaction();
            var patientFiles = session.Query<PatientFile>().Where(x => x.Patient.ID == ID);
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

            return patientFileETOs;
        }
        [HttpGet]
        [ActionName("Get")]
        public IEnumerable<PatientFileETO> Get()
        {
            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            session.BeginTransaction();
            var patientFiles = session.Query<PatientFile>();
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

            return patientFileETOs;
        }

        [HttpPut]
        [ActionName("Put")]
        public void Put(PatientFileETO eto)
        {
            var session = SessionFactory.SessionFactoryInstance.OpenSession();
            var transaction = session.BeginTransaction();

            var patientFile = new PatientFile
            {
                Name = eto.Name,
                Description = eto.Description,
                Patient = session.Get<Patient>(eto.patient.ID),
                LabTests = new List<LabTest>()
            };

            session.Save(patientFile);
            transaction.Commit();
        }
    }
}

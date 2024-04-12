using BlazorApp.Model;

namespace BlazorApp.Services
{
    public class PatientService
    {
        public List<PatientData> patients = new List<PatientData>();
        public void AddPatient(PatientData patient)
        {
            patients.Add(patient);
        }
        public List<PatientData> Getpatient()
        {
            return patients;
        }
    }
}

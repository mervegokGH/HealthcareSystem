namespace HealthcareSystem.Models
{
    public class Prescription
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string Medication { get; set; }
        public string Dosage { get; set; }

        public Patient Patient { get; set; }
    }
}

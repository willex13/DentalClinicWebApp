using DentalClinic.Domain.Abstractions;
using DentalClinic.Domain.Dentists;
using DentalClinic.Domain.Patients;
using DentalClinic.Domain.Treatments;

namespace DentalClinic.Domain.TreatmentRecords
{
    public class TreatmentRecord : Entity
    {
        public DateTime? Date { get; set; }
        public string Notes { get; set; } = string.Empty;
        public Patient Patient { get; set; } = new();
        public Treatment Treatment { get; set; } = new();
        public Dentist Dentist { get; set; } = new();

    }
}

using DentalClinic.Domain.Abstractions;
using DentalClinic.Domain.Appointments;
using DentalClinic.Domain.TreatmentRecords;

namespace DentalClinic.Domain.Dentists
{
    public class Dentist : Entity
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Specialization { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string NIF { get; set; } = string.Empty;

        public ICollection<Appointment> Appointments { get; set; } = [];
        public ICollection<TreatmentRecord> TreatmentRecords { get; set; } = [];
    }
}

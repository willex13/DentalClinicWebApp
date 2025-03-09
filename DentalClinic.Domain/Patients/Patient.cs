using DentalClinic.Domain.Abstractions;
using DentalClinic.Domain.Appointments;
using DentalClinic.Domain.Billings;

namespace DentalClinic.Domain.Patients
{
    public class Patient : Entity
    {

        public  string FirstName { get; set; } = string.Empty;
        public  string LastName { get; set; } = string.Empty;
        public  string Phone { get; set; } = string.Empty;
        public DateTime? DateOfBirth { get; set; }
        public char Gender { get; set; } = '\0';
        public string Email { get; set; } = string.Empty;
        public string NIF { get; set; } = string.Empty;
        public string MedicalHistory { get; set; } = string.Empty;
        public ICollection<Appointment> Appointments { get; set; } = [];
        public ICollection<Billing> Billings { get; set; } = [];
    }
}

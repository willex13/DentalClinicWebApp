using DentalClinic.Domain.Abstractions;
using DentalClinic.Domain.Dentists;
using DentalClinic.Domain.Patients;
using DentalClinic.Domain.Rooms;

namespace DentalClinic.Domain.Appointments
{
    public class Appointment : Entity
    {
        public DateTime AppointmentDate { get; set; } = DateTime.Now;
        public TimeOnly AppointmentTime { get; set; }
        public string Status { get; set; } = string.Empty; //Scheduled, Completed, Cancelled
        public Dentist Dentist { get; set; } = new();
        public Patient Patient { get; set; } = new();
        public Room Room { get; set; } = new();
    }
}

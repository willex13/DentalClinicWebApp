using DentalClinic.Domain.Abstractions;

namespace DentalClinic.Domain.Staffs
{
    public class Staff : Entity
    {
        public  string FirstName { get; set; } = string.Empty;
        public  string LastName { get; set; } = string.Empty;
        public  string Phone { get; set; } = string.Empty;
        public int Role { get; set; } //Receptionist, Hygienist, etc.
        public string NIF { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}

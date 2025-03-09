using DentalClinic.Domain.Abstractions;
using DentalClinic.Domain.Appointments;

namespace DentalClinic.Domain.Rooms
{
    public class Room : Entity
    {
        public string RoomName { get; set; } = string.Empty;
        public string RoomType { get; set; } = string.Empty;
        public int Status { get; set; } //Available, Occupied
        public ICollection<Appointment> Appointments { get; set; } = [];
    }
}

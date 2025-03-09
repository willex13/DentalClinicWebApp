using DentalClinic.Domain.Appointments;
using DentalClinic.Domain.Billings;
using DentalClinic.Domain.Dentists;
using DentalClinic.Domain.Patients;
using DentalClinic.Domain.Rooms;
using DentalClinic.Domain.Staffs;
using DentalClinic.Domain.TreatmentRecords;
using DentalClinic.Domain.Treatments;
using Microsoft.EntityFrameworkCore;

namespace DentalClinic.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Billing> Billings { get; set; }
        public DbSet<Dentist> Dentists { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<TreatmentRecord> TreatmentRecords { get; set; }
        public DbSet<Treatment> Treatments { get; set; }
    }
}

using DentalClinic.Domain.Patients;
using Microsoft.EntityFrameworkCore;

namespace DentalClinic.Infrastructure.Repositories
{
    public class PatientRepository : IPatientRepository
    {

        private readonly ApplicationDbContext _context;

        public PatientRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddPatientAsync(Patient patient)
        {
            _context.Patients.Add(patient);
            await _context.SaveChangesAsync();
        }

        public async Task DeletePatientAsync(int id)
        {
            var item = await _context.Patients.FindAsync(id);
            if (item != null)
                await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Patient>> GetAllPatientsAsync() => await _context.Patients.ToListAsync();

        public async Task<Patient> GetPatientAsync(int id) => await _context.Patients.FindAsync(id) ?? new();

        public async Task UpdatePatientAsync(Patient patient)
        {
            _context.Entry(patient).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}

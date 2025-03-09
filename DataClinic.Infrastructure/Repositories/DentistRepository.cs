using DentalClinic.Domain.Billings;
using DentalClinic.Domain.Dentists;
using Microsoft.EntityFrameworkCore;

namespace DentalClinic.Infrastructure.Repositories
{
    public class DentistRepository : IDentistRepository
    {
        private readonly ApplicationDbContext _context;

        public DentistRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddDentistsAsync(Dentist dentist)
        {
            _context.Dentists.Add(dentist);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteDentistsAsync(int id)
        {
            var item = await _context.Dentists.FindAsync(id);
            if (item != null)
                await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Dentist>> GetAllDentistsAsync() => await _context.Dentists.ToListAsync();

        public async Task<Dentist> GetDentistsAsync(int id) => await _context.Dentists.FindAsync(id) ?? new();

        public async Task UpdateDentistsAsync(Dentist dentist)
        {
            _context.Entry(dentist).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}

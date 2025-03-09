using DentalClinic.Domain.Treatments;
using Microsoft.EntityFrameworkCore;

namespace DentalClinic.Infrastructure.Repositories
{
    public class TreatmentRepository : ITreatmentRepository
    {
        private readonly ApplicationDbContext _context;

        public TreatmentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddTreatmentAsync(Treatment treatment)
        {
            _context.Treatments.Add(treatment);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTreatmentAsync(int id)
        {
            var item = await _context.Treatments.FindAsync(id);
            if (item != null)
                await _context.SaveChangesAsync();
        }

        public async Task<Treatment> GetTreatmentAsync(int id) => await _context.Treatments.FindAsync(id) ?? new();

        public async Task<IEnumerable<Treatment>> GetAllTreatmentsAsync() => await _context.Treatments.ToListAsync();

        public async Task UpdateTreatmentAsync(Treatment treatment)
        {
            _context.Entry(treatment).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}

using DentalClinic.Domain.Rooms;
using DentalClinic.Domain.TreatmentRecords;

namespace DentalClinic.Infrastructure.Repositories
{
    public class TreatmentRecordRepository : ITreatmentRecordRepository
    {
        private readonly ApplicationDbContext _context;

        public TreatmentRecordRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddTreatmentRecordAsync(TreatmentRecord treatmentRecord)
        {
            _context.TreatmentRecords.Add(treatmentRecord);
            await _context.SaveChangesAsync();
        }

        public async Task<TreatmentRecord> GetTreatmentAsync(int id) => await _context.TreatmentRecords.FindAsync(id) ?? new();
    }
}

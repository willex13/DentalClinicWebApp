using DentalClinic.Domain.Billings;
using Microsoft.EntityFrameworkCore;

namespace DentalClinic.Infrastructure.Repositories
{
    public class BillingRepository : IBillingRepository
    {
        private readonly ApplicationDbContext _context;

        public BillingRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddBillingsAsync(Billing billing)
        {
            _context.Billings.Add(billing);
            await _context.SaveChangesAsync();
        }

        public  async Task DeleteBillingsAsync(int id)
        {
            var item = await _context.Billings.FindAsync(id);
            if (item != null)
                await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Billing>> GetAllBillingsAsync() => await _context.Billings.ToListAsync();

        public async Task<Billing> GetBillingsAsync(int id) => await _context.Billings.FindAsync(id) ?? new();

        public async Task UpdateBillingsAsync(Billing billing)
        {
            _context.Entry(billing).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}

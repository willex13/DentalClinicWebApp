using DentalClinic.Domain.Staffs;
using Microsoft.EntityFrameworkCore;

namespace DentalClinic.Infrastructure.Repositories
{
    public class StaffRepository : IStaffRepository
    {
        private readonly ApplicationDbContext _context;

        public StaffRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddStaffAsync(Staff staff)
        {
            _context.Staffs.Add(staff);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteStaffAsync(int id)
        {
            var item = await _context.Staffs.FindAsync(id);
            if (item != null)
                await _context.SaveChangesAsync();
        }

        public async Task<Staff> GetStaffAsync(int id) => await _context.Staffs.FindAsync(id) ?? new();

        public async Task<IEnumerable<Staff>> GetAllStaffsAsync() => await _context.Staffs.ToListAsync();
        public async Task UpdateStaffAsync(Staff staff)
        {
            _context.Entry(staff).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}

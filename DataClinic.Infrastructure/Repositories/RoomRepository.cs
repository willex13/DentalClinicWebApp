using DentalClinic.Domain.Rooms;
using Microsoft.EntityFrameworkCore;

namespace DentalClinic.Infrastructure.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private readonly ApplicationDbContext _context;

        public RoomRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddRoomAsync(Room room)
        {
            _context.Rooms.Add(room);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRoomAsync(int id)
        {
            var item = await _context.Rooms.FindAsync(id);
            if (item != null)
                await _context.SaveChangesAsync();
        }

        public async Task<Room> GetRoomAsync(int id) => await _context.Rooms.FindAsync(id) ?? new();

        public async Task<IEnumerable<Room>> GetAllRoomsAsync() => await _context.Rooms.ToListAsync();

        public async Task UpdateRoomAsync(Room room)
        {
            _context.Entry(room).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}

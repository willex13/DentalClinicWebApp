using DentalClinic.Domain.Treatments;

namespace DentalClinic.Domain.Staffs
{
    public interface IStaffRepository
    {
        Task<IEnumerable<Staff>> GetAllStaffsAsync();
        Task<Staff> GetStaffAsync(int id);
        Task AddStaffAsync(Staff staff);
        Task UpdateStaffAsync(Staff staff);
        Task DeleteStaffAsync(int id);
    }
}

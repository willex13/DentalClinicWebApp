
namespace DentalClinic.Domain.Dentists
{
    public interface IDentistRepository
    {
        Task<IEnumerable<Dentist>> GetAllDentistsAsync();
        Task<Dentist> GetDentistsAsync(int id);
        Task AddDentistsAsync(Dentist dilling);
        Task UpdateDentistsAsync(Dentist dentist);
        Task DeleteDentistsAsync(int id);
    }
}

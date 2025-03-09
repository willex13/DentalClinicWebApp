
namespace DentalClinic.Domain.Billings
{
    public interface IBillingRepository
    {
        Task<IEnumerable<Billing>> GetAllBillingsAsync();
        Task<Billing> GetBillingsAsync(int id);
        Task AddBillingsAsync(Billing billing);
        Task UpdateBillingsAsync(Billing billing);
        Task DeleteBillingsAsync(int id);
    }
}

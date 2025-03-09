namespace DentalClinic.Domain.TreatmentRecords
{
    public interface ITreatmentRecordRepository
    {
        Task<TreatmentRecord> GetTreatmentAsync(int id);
        Task AddTreatmentRecordAsync(TreatmentRecord treatmentRecord);
    }
}

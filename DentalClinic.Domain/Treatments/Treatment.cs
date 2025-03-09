using DentalClinic.Domain.Abstractions;
using DentalClinic.Domain.TreatmentRecords;
using System.ComponentModel.DataAnnotations.Schema;

namespace DentalClinic.Domain.Treatments
{
    public class Treatment : Entity
    {
        public string TreatmentName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18,2)")]
        public decimal Cost { get; set; }
        public ICollection<TreatmentRecord> TreatmentRecords { get; set; } = [];
    }
}

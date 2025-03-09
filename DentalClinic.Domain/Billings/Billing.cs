using DentalClinic.Domain.Abstractions;
using DentalClinic.Domain.Patients;
using System.ComponentModel.DataAnnotations.Schema;

namespace DentalClinic.Domain.Billings
{
    public class Billing : Entity
    {
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amout { get; set; }
        public DateTime Billingdate { get; set; }
        public string Status { get; set; } = string.Empty; //Paid, Pending, Overdue
        public Patient Patient { get; set; } = new();

    }
}

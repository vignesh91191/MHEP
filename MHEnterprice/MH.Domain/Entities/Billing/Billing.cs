using MDH.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Billing
{
    public class Billing : BaseEntity
    {

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        [ForeignKey("User")]
        public int EmployeeId { get; set; }
        public DateTime BillingDate { get; set; }

        [ForeignKey("EnumMaster")]
        public int? BillingStatusNumber { get; set; }
        public decimal Subtotal { get; set; } // Total amount before tax
        public decimal TaxAmount { get; set; } // Total tax amount
        public decimal TotalAmount { get; set; } // Total amount including tax
        public  required List<BillingDetail> BillDetail { get; set; }
    }
}

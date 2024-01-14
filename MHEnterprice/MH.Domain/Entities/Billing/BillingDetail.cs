using MDH.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Billing
{
    public class BillingDetail : BaseEntity
    {
        [ForeignKey("Billing")]
        public int BillId { get; set; }

        [ForeignKey("Product")]
        public int? ProductId { get; set; }

        [ForeignKey("Supplier")]
        public int? SupplierId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }

        [ForeignKey("EnumMaster")]
        public int UnitOfMaterial { get; set; }
    }
}

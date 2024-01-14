using MDH.Domain.Entities;
namespace Domain.Entities.Tax
{
    public class Tax : BaseEntity
    {
        public required string TaxName { get; set; }
        public string? TaxDescription { get; set; }
        public required List<TaxDetail> TaxDetail { get; set; }
    }
}

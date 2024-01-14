using MDH.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace Domain.Entities.Product
{
    public class Product : BaseEntity
    {
        public required string ProductName { get; set; }
        public string? ProductDescription { get; set; }

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public int Qty { get; set; }
        public double? Price { get; set; }
    }
}

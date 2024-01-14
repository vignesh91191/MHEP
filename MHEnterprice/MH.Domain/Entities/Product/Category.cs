using MDH.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Product
{
    public class Category : BaseEntity
    {
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public required string CategoryName { get; set; }
        
        //Navigation Property
        public virtual List<Product>? Products { get; set; }
    }
}

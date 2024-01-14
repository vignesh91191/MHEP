using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MDH.Domain.Entities;

namespace Domain.Entities.Supplier
{
    public class Supplier : BaseEntity
    {
        public required string SupplierName { get; set; }
        public string? SupplierDescription { get; set; }
    }
}

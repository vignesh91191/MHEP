using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Tax
{
    public class TaxDetail
    {
        [ForeignKey("Tax")]
        public int TaxId { get; set; }

        [Key]
        public int TaxDetailId { get; set; }
        public decimal TaxRate { get; set; }
        public bool IsActive { get; set; }
    }
}

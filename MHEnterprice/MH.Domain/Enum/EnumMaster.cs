using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enum
{
    public class EnumMaster
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }

        [ForeignKey("Enum")]
        public int EnumId { get; set; }
        public int IsActive { get; set; }
    }
}

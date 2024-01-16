using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MDH.Domain.Entities;

namespace Domain.Entities.Service
{
    public class Service : BaseEntity
    {
        public required string ServiceName { get; set; }
        public string? ServiceDescription { get; set; }

        [ForeignKey("ServiceType")]
        public required int ServiceTypeId { get; set; } 
    }
}

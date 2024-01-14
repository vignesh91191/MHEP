using System;
using System.Collections.Generic;
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
    }
}

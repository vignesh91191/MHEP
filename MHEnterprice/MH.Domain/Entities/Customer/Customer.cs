using MDH.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Customer
{
    public class Customer : BaseEntity
    {
        public required string Name { get; set; }
        public string? EmailId { get; set; }
        public required Address CustomerAddress { get; set; }
        public Address? BillAddress { get; set; }
        public bool IsSameAsBillingAddress { get; set; }
        public string? Phone { get; set; }
    }
}

using MDH.Domain.Entities;
namespace Domain.Entities.Service
{
    public class ServiceType : BaseEntity
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
    }
}

using Domain.Entities.Product;
using Domain.Interface.IRepositories;
using Infrastructure.Persistence.Context;
using Infrastructure.Persistence.Repositories.Base;


namespace Infrastructure.Persistence.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(MHDbContext dbContext) : base(dbContext)
        {
        }
    }
}

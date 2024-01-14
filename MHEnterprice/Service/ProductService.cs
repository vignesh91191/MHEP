using Domain.Entities.Product;
using Domain.Interface.IUnitOfWork;
using Service.Interface;

namespace Service
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> AddProductAsync(Product product)
        {
            await _unitOfWork.GetRepository<Product>().AddAsync(product);
            _unitOfWork.Commit();
            return product.Id;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            var product = await _unitOfWork.GetRepository<Product>().GetAllAsync();
            return product;
        }

        public async Task<Product> GetProductByIdAsync(int productId)
        {
            var product = await _unitOfWork.GetRepository<Product>().GetByIdAsync(productId);
            return product;
        }

        public bool UpdateProduct(Product product)
        {
            _unitOfWork.GetRepository<Product>().Update(product);
            _unitOfWork.Commit();
            return true;
        }
    }

}

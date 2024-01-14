using Domain.UnitOfWork;
using MDH.Domain.Entities;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ProductService : IProductService
    {
        private IUnitOfWork _unitOfWork;  
        public ProductService(IUnitOfWork unitOfWork) {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> CreateProduct(Product productDetails)
        {
            if (productDetails != null)
            {
                await _unitOfWork.Products.Add(productDetails);
                var result = await _unitOfWork.CommitAsync();
                if (result > 0)
                    return true;
                else
                    return false;
            }
            return false;
        }

        public async Task<bool> DeleteProduct(int productId)
        {
            if (productId > 0)
            {
                var productDetails = await _unitOfWork.Products.GetById(productId);
                if (productDetails != null)
                {
                    _unitOfWork.Products.Delete(productDetails);
                    var result = await _unitOfWork.CommitAsync();

                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            var productDetailsList = await _unitOfWork.Products.GetAll();
            return productDetailsList;
        }

        public async Task<Product> GetProductById(int productId)
        {
            var productDetails = await _unitOfWork.Products.GetById(productId);
            return productDetails;
        }

        public async Task<bool> UpdateProduct(Product productDetails)
        {
            if (productDetails != null)
            {
                var product = await _unitOfWork.Products.GetById(product.Id);
                if (product != null)
                {
                    product.ProductName = productDetails.ProductName;
                    product.ProductDescription = productDetails.ProductDescription;
                    

                    _unitOfWork.Products.Update(product);

                    var result = async _unitOfWork.CommitAsync();

                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }
    }
}

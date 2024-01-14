﻿using Domain.Entities.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProducts();
        Task<Product> GetProductByIdAsync(int productId);
        Task AddProductAsync(Product product);
        void UpdateProductAsync(Product product);
    }
}

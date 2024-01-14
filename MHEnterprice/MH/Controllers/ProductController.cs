using Domain.Entities.Product;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;

namespace MH.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        /// <summary>
        /// Get the list of product
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetProductList()
        {
            var productDetailsList = await _productService.GetAllProducts();
            if (productDetailsList == null)
            {
                return NotFound();
            }
            return Ok(productDetailsList);
        }

        /// <summary>
        /// Get product by id
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        [HttpGet("{productId}")]
        public async Task<IActionResult> GetProductById(int productId)
        {
            var productDetails = await _productService.GetProductByIdAsync(productId);

            if (productDetails != null)
            {
                return Ok(productDetails);
            }
            else
            {
                return BadRequest();
            }
        }

        /// <summary>
        /// Add a new product
        /// </summary>
        /// <param name="productDetails"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateProduct(Product productDetails)
        {
            var productId = await _productService.AddProductAsync(productDetails);
            return Ok(productId);
        }

        /// <summary>
        /// Update the product
        /// </summary>
        /// <param name="productDetails"></param>
        /// <returns></returns>
        [HttpPut]
        public bool UpdateProduct(Product productDetails)
        {
            var isUpdated = _productService.UpdateProduct(productDetails);
            return isUpdated;
        }

        ///// <summary>
        ///// Delete product by id
        ///// </summary>
        ///// <param name="productId"></param>
        ///// <returns></returns>
        //[HttpDelete("{productId}")]
        //public async Task<IActionResult> DeleteProduct(int productId)
        //{
        //    var isProductCreated = await _productService.DeleteProduct(productId);

        //    if (isProductCreated)
        //    {
        //        return Ok(isProductCreated);
        //    }
        //    else
        //    {
        //        return BadRequest();
        //    }
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce.DAL.Repositories;
using Ecommerce.Models.Entities;

namespace Ecommerce.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product> GetProductByNameAsync(string nameProduct)
        {
            var product = await _productRepository.GetProductByNameAsync(nameProduct);

            return product;
        }

        public async Task<IList<Product>> GetAllProductsAsync()
        {
            var products = await _productRepository.GetAllProductsAsync();

            return products;
        }
    }
}

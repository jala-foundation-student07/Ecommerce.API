using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.DAL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly EcommerceDbContext _ecommerceDbContext;

        public ProductRepository(EcommerceDbContext ecommerceDbContext)
        {
            _ecommerceDbContext = ecommerceDbContext;
        }

        public async Task<Product> GetProductByNameAsync(string nameProduct)
        {
            var product = await _ecommerceDbContext.Products
                .FirstOrDefaultAsync(p => p.FirstName == nameProduct);

            return product;
        }

        public async Task<IList<Product>> GetAllProductsAsync()
        {
            var products = await _ecommerceDbContext.Products
                .ToListAsync();

            return products;
        }
    }
}

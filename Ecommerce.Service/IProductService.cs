using Ecommerce.Models.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Service
{
    public interface IProductService
    {
        /// <summary>
        /// Return the product find by name.
        /// </summary>
        /// <param name="nameProduct">Product identifier</param>
        /// <returns></returns>
        Task<Product> GetProductByNameAsync(string nameProduct);

        /// <summary>
        /// Return all the products.
        /// </summary>
        /// <returns>Products</returns>
        Task<IList<Product>> GetAllProductsAsync();
    }
}

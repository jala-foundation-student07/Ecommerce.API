using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce.Models.Entities;

namespace Ecommerce.DAL.Repositories
{
    public interface IProductRepository
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

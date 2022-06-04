using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Ecommerce.API.ModelsDto;
using Ecommerce.Service;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers
{
    [Route("api/products")]
    public class ProductController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IProductService _productService;

        public ProductController(IMapper mapper, IProductService productService)
        {
            _mapper = mapper;
            _productService = productService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productName">Product Identifier.</param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(ProductDto), (int)HttpStatusCode.Created)]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetProductAsync(string productName)
        {
            var product = await _productService.GetProductByNameAsync(productName);

            if (product is null) return NotFound();

            var createProductDto = _mapper.Map<ProductDto>(product);

            return Ok(createProductDto);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>The list of Products.</returns>
        [HttpGet]
        [ProducesResponseType(typeof(IList<ProductDto>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetProductsAsync()
        {
            var departments = await _productService.GetAllProductsAsync();

            if (departments is null) return NotFound();

            var departmentListDto = _mapper.Map<IList<ProductDto>>(departments);

            return Ok(departmentListDto);
        }
    }
}

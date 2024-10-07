using Ecommerce.application.Contract.Interface;
using Ecommerce.application.Contract.Service;
using Ecommerce.application.Dtos;
using Ecommerce.Domain;
using ECOMMERCE.DOMAIN;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.Now;

namespace Ecommerce.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productservice;
        public ProductController(IProductService productservice)
        {
            _productservice = productservice;
        }
        // user story As a product, I should display my details.
        [HttpGet]
        public async Task<IActionResult> GetAllProduct()
        {
            var products = await _productservice.GetAllproducts();
            return Ok(products);
        }
        // User Story :- As a product, I should retrieve all products 
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _productservice.GetProducts();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetproductById(int id)
        {
            var product = await _productservice.GetproductById(id);
            if (product == null)
                return NotFound();

            return Ok(product);
        }

        //- As a product, I should add new products.
        [HttpPost]
        public async Task<IActionResult> CreateProduct(Product product)
        {
            await _productservice.CreateProduct(product);
            return Ok();
        }

        //- As a product, I should edit my info.

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, Product product)
        {
            if (id != product.Id)
                return BadRequest();

            await _productservice.UpdateProduct(product);
            return Ok();
        }
        // - As a product, I should delete it.
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            await _productservice.DeleteProduct(id);
            return NoContent();
        }
    }
}

using AutoMapper;
using Ecommerce.application.Contract.Interface;
using Ecommerce.application.Repository;
using Ecommerce.Domain;
using ECOMMERCE.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.application.Contract.Service
{
    public class ProductService :  IProductService
    {
        private readonly IProductRepository _productrepository;
        
        public ProductService(IProductRepository productrepositry) {
            _productrepository = productrepositry;
        
        
        }

        public async Task CreateProduct(Product product)
        {
            await _productrepository.AddAsync(product);
        }

        public async Task DeleteProduct(int id)
        {
            await _productrepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Product>> GetAllproducts()
        {
            return await _productrepository.GetAllAsync();
        }

        public async Task<Product> GetproductById(int id)
        {
            return await _productrepository.GetByIdAsync(id);
        }

        public async  Task UpdateProduct(Product product)
        {
            
            await _productrepository.UpdateAsync(product);
        }
    }
}

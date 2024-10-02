using Ecommerce.application.Dtos;
using Ecommerce.Domain;
using ECOMMERCE.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.application.Contract.Interface
{
    public interface IProductService
    {
        public Task CreateProduct(Product product);
        public Task DeleteProduct(int id);
        public Task<IEnumerable<Product>> GetAllproducts();

        public Task<Product> GetproductById(int id);

        public Task UpdateProduct(Product product);

        
    }
}

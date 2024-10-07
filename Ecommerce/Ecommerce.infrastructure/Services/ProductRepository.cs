using Ecommerce.application.Repository;
using Ecommerce.Domain;
using Ecommerce.infrastructure.Presistance;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace Ecommerce.infrastructure.Services
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly DbSet<Product> _dbSet;
        public ProductRepository(DBContextApplication context) : base(context)
        {
            _dbSet = context.Set<Product>();
        }

        public async Task AddCategoryByProductId(int productId)
        {
            await var p= (from Product in _dbSet
                   where Product.Id == productId
                   select Product).ToListAsync();
        }

        public   async Task<List<Product>> GetProducts()
        { 
            List<Product> products = new List<Product>();
            foreach (Product product in  _dbSet)
            {
                products.Add(product);
            }
            return  products;
        }
    }
}

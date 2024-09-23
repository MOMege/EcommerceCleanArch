using Ecommerce.application.Repository;
using Ecommerce.infrastructure.Presistance;
using ECOMMERCE.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.infrastructure.Services
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DBContextApplication _context;

        public CategoryRepository(DBContextApplication context)
        {
            _context = context;
        }

        public async Task createCategory(Category category)
        {
            await _context.Categories.AddAsync(new Category() { Id = 1, Name = "Cat 1" });

        }
            public Task<Category> GetCategoryById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}

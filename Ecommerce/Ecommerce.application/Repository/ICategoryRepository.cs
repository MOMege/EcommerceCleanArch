using ECOMMERCE.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.application.Repository
{
    public interface ICategoryRepository
    {

        public Task createCategory(Category category);
        public Task<Category> GetCategoryById(int Id);
    }
}

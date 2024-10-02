using Ecommerce.application.Dtos;
using Ecommerce.application.Repository;
using ECOMMERCE.DOMAIN;


namespace Ecommerce.application.Contract.Interface
{
    public interface ICategoryService 
    {

        public Task< IEnumerable<Category>> GetAllCategories();

        public Task<Category> GetCategoryById(int id);

        public Task CreateCategory(DtoCategory dtoCategory);

        public Task UpdateCategory(Category category);

        public Task DeleteCategory(int id);
    }
}

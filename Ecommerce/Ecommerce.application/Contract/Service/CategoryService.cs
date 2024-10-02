using AutoMapper;
using Ecommerce.application.Contract.Interface;
using Ecommerce.application.Dtos;
using Ecommerce.application.Repository;
using ECOMMERCE.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.application.Contract.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;       

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
           
        }

        public async Task CreateCategory(DtoCategory dtoCategory)
        {
            var catmapModel = _mapper.Map<Category>(dtoCategory);
            await _categoryRepository.AddAsync(catmapModel);
        }

        public async Task DeleteCategory(int id)
        {
            await _categoryRepository.DeleteAsync(id);
        }

        public Task<IEnumerable<Category>> GetAllCategories()
        {
            return _categoryRepository.GetAllAsync();
        }

        public Task<Category> GetCategoryById(int id)
        {
            return _categoryRepository.GetByIdAsync(id);
        }

        public  async Task UpdateCategory(Category category)
        {
            var catmapModel = _mapper.Map<Category>(category);
            await _categoryRepository.UpdateAsync(catmapModel);
        }
    }
}

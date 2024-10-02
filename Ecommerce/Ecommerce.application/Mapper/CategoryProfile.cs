using AutoMapper;
using Ecommerce.application.Dtos;
using Ecommerce.Domain;
using ECOMMERCE.DOMAIN;


namespace Ecommerce.application.Mapper
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile() {
            CreateMap<DtoCategory, Category>();
           
        }

         
    }
}

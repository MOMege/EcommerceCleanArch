using Ecommerce.application.Contract.Interface;
using Ecommerce.application.Contract.Service;
using Ecommerce.application.Mapper;
using Ecommerce.application.Repository;
using Ecommerce.infrastructure.Presistance;
using Ecommerce.infrastructure.Services;
using ECOMMERCE.DOMAIN;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Ecommerce.api
{
    public static class DepandancyInjection
    {

        public static IServiceCollection AddApiServices(this IServiceCollection Services,IConfiguration configuration)
        { 
            Services.AddScoped<ICategoryRepository, CategoryRepository>();
            Services.AddScoped<ICategoryService, CategoryService>();
            Services.AddScoped<IProductRepository, ProductRepository>();
            Services.AddScoped<IProductService, ProductService>();
            return Services;
        }

        public static WebApplication UseApiservices(this WebApplication application)
        {
            return application;
        }

    }
}

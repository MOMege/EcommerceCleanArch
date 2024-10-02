using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Graph;
using Microsoft.Graph.Models;


namespace Ecommerce.application.Extension
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddAppServices(this IServiceCollection service, IConfiguration configuration )
        {
            return service;
        }

        public static WebApplication UseAppServices(this WebApplication webApplication)
        {
            return webApplication;
        }
            }
}

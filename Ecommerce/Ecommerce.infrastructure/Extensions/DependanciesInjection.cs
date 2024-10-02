using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Graph.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.infrastructure.Extensions
{
    public static class DependanciesInjection
    {
        public static IServiceCollection AddInfrastrucureService(this IServiceCollection services,IConfiguration config)
        {

            return services;
        }

        public static WebApplication UseinfrastrureService(this WebApplication webapp)
        {
            return webapp;
        }

    }
}

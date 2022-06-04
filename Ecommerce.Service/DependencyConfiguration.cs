using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce.DAL;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.Service
{
    public static class DependencyConfiguration
    {
        public static IServiceCollection ConfigureServiceDependencies(this IServiceCollection services)
        {
            services.AddTransient<IProductService, ProductService>();

            services.ConfigureDalDependencies();

            return services;
        }

        public static void ConfigureServiceDbContexts(this IServiceCollection services, string connectionString)
        {
            services.ConfigureDalDbContexts(connectionString, asNoTracking: false);
        }
    }
}

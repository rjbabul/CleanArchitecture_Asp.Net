using Application.Abstraction;
using Infrastracture.Database;
using Infrastracture.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastracture
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastracture(this IServiceCollection services)
        {
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ApplicationDbContext>();
            return services;
        }
    }
}

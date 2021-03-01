using Crud.Services.CrudServices;
using Crud.Services.ICrudServices;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crud.Services
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection AddEmployeeServices(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeCrudServices, EmployeeCrudServices>();
            return services;
        }
    }
}

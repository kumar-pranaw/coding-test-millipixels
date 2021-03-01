using Crud.Repository.IRepository;
using Crud.Repository.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crud.Repository
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection AddRepositoryServices(this IServiceCollection services)
        {
            services.AddScoped<ICrudRepository, CrudRepository>();
            services.AddScoped<IDbConnectionFactory, SqlConnectionFactory>();
            return services;
        }
    }
}

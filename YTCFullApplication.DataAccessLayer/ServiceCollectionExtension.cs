﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTCFullApplication.DataAccessLayer
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddDataAccessLayer(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                string connectionString = configuration.GetConnectionString("DefaultConnection") ??
                throw new Exception("ConnectionString non trovata in appsettings.json");
                options.UseSqlite(connectionString);
            }, ServiceLifetime.Scoped);
            return services;
        }

    }
}

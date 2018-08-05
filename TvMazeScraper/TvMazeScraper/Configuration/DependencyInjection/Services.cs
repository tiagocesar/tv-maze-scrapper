﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TvMazeScraper.Services;

namespace TvMazeScraper.Configuration.DependencyInjection
{
    public static class Services
    {
        public static IServiceCollection AddServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddTransient<IShowService, ShowService>();

            return services;
        }
    }
}
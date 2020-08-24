using Microsoft.Extensions.DependencyInjection;
using PokemonDomain.Repositories;
using PokemonDomain.Services;
using PokemonInfrastructure.Repositories;
using PokemonInfrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonAPI.Utility
{
    public static class ServiceExtensions
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IPokemonService, PokemonService>();
            services.AddScoped<IPokemonRepository, PokemonRepository>();
            return services;
        }
    }
}

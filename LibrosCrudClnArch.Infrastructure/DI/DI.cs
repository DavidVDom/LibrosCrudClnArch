using LibrosCrudClnArch.Application.Abstractions;
using LibrosCrudClnArch.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace LibrosCrudClnArch.Infrastructure.DI
{
    public static class DI
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<ILibroRepository, LibroRepository>();

            return services;
        }
    }
}

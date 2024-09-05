using LibrosCrudClnArch.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace LibrosCrudClnArch.Application.DI
{
    public static class DI
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<ILibrosService, LibrosService>();

            return services;
        }
    }
}

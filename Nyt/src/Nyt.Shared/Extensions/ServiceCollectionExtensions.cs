using Microsoft.Extensions.DependencyInjection;
using Nyt.Shared.Services;

namespace Nyt.Shared.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSharedServices(this IServiceCollection services)
        {
            // Register shared services
            services.AddSingleton<ApiService>(); // Example service

            return services;
        }
    }
}

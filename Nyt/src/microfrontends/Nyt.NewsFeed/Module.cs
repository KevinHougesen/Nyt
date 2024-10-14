using Microsoft.Extensions.DependencyInjection;
using Nyt.Shared.Extensions; // Include the namespace with the extension method

namespace Nyt.NewsFeed
{
    public class Module
    {
        public static void Main()
        {
            // This entry point should remain empty
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddSharedServices();
        }
    }
}

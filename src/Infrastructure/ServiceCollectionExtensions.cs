using Microsoft.Extensions.DependencyInjection;

namespace ReviewService.Infrastructure
{
    public static class InfrastructureCollectionExtensions
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddSingleton<MongoDbService>();
            return services;
        }
    }
}

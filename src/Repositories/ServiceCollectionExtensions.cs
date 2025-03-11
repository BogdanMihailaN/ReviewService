using Microsoft.Extensions.DependencyInjection;
using ReviewService.Repositories.Review;

namespace ReviewService.Repositories
{
    public static class RepositoryCollectionExtensions
    {
        public static IServiceCollection AddReviewRepositories(this IServiceCollection services)
        {
            services.AddTransient<IReviewRepository, ReviewRepository>();
            return services;
        }
    }
}

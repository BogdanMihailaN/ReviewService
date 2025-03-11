using Microsoft.Extensions.DependencyInjection;
using ReviewService.Services.Review;

namespace ReviewService.Services
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddReviewServices(this IServiceCollection services)
        {
            services.AddTransient<IReviewService, Review.ReviewService>();
            return services;
        }
    }
}

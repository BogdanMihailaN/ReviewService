using ReviewService.Domain.Models;

namespace ReviewService.Repositories.Review
{
    public interface IReviewRepository
    {
        Task<List<ReviewModel>> GetAllReviewsAsync();
        Task<ReviewModel> GetReviewByIdAsync(Guid id);
        Task CreateReviewAsync(ReviewModel review);
        Task UpdateReviewAsync(Guid id, ReviewModel updatedReview);
        Task DeleteReviewAsync(Guid id);
    }
}

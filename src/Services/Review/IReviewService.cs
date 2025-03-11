using ReviewService.Domain.Models;

namespace ReviewService.Services.Review
{
    public interface IReviewService
    {
        Task<List<ReviewModel>> GetAllReviewsAsync();
        Task<ReviewModel> GetReviewByIdAsync(Guid id);
        Task CreateReviewAsync(ReviewModel review);
        Task UpdateReviewAsync(Guid id, ReviewModel updatedReview);
        Task DeleteReviewAsync(Guid id);
    }
}

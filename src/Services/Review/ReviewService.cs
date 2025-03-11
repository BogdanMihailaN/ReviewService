using ReviewService.Domain.Models;
using ReviewService.Repositories.Review;

namespace ReviewService.Services.Review
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _reviewRepository;

        public ReviewService(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }

        public async Task CreateReviewAsync(ReviewModel review)
        {
            await _reviewRepository.CreateReviewAsync(review);
        }

        public async Task DeleteReviewAsync(Guid id)
        {
            await _reviewRepository.DeleteReviewAsync(id);
        }

        public async Task<List<ReviewModel>> GetAllReviewsAsync()
        {
            return await _reviewRepository.GetAllReviewsAsync();
        }

        public async Task<ReviewModel> GetReviewByIdAsync(Guid id)
        {
            return await _reviewRepository.GetReviewByIdAsync(id);
        }

        public async Task UpdateReviewAsync(Guid id, ReviewModel updatedReview)
        {
            await _reviewRepository.UpdateReviewAsync(id, updatedReview);
        }
    }
}

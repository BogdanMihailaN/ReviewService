using MongoDB.Driver;
using ReviewService.Domain.Models;
using ReviewService.Infrastructure;

namespace ReviewService.Repositories.Review
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly MongoDbService _mongoDbService;

        public ReviewRepository(MongoDbService mongoDbService)
        {
            _mongoDbService = mongoDbService;
        }

        public async Task<List<ReviewModel>> GetAllReviewsAsync()
        {
            var collection = _mongoDbService.GetReviewCollection();
            return await collection.Find(_ => true).ToListAsync();
        }

        public async Task<ReviewModel> GetReviewByIdAsync(Guid id)
        {
            var collection = _mongoDbService.GetReviewCollection();
            return await collection.Find(review => review.Id == id).FirstOrDefaultAsync();
        }

        public async Task CreateReviewAsync(ReviewModel review)
        {
            var collection = _mongoDbService.GetReviewCollection();
            await collection.InsertOneAsync(review);
        }

        public async Task UpdateReviewAsync(Guid id, ReviewModel updatedReview)
        {
            var collection = _mongoDbService.GetReviewCollection();
            updatedReview.Id = id;
            await collection.ReplaceOneAsync(review => review.Id == id, updatedReview);
        }

        public async Task DeleteReviewAsync(Guid id)
        {
            var collection = _mongoDbService.GetReviewCollection();
            await collection.DeleteOneAsync(review => review.Id == id);
        }
    }
}

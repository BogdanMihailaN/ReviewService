using Microsoft.AspNetCore.Mvc;
using ReviewService.Domain.Models;
using ReviewService.Services.Review;

namespace ReviewService.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewService _reviewService;

        public ReviewController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllReviewsAsync()
        {
            var products = await _reviewService.GetAllReviewsAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetReviewByIdAsync(Guid id)
        {
            var product = await _reviewService.GetReviewByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> CreateReviewAsync([FromBody] ReviewModel newReview)
        {
            newReview.Id = Guid.NewGuid();
            await _reviewService.CreateReviewAsync(newReview);
            return Ok(newReview);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateReviewAsync(Guid id, [FromBody] ReviewModel updatedReview)
        {
            await _reviewService.UpdateReviewAsync(id, updatedReview);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReviewAsync(Guid id)
        {
            await _reviewService.DeleteReviewAsync(id);
            return NoContent();
        }
    }
}

using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace ReviewService.Domain.Models
{
    public class ReviewModel
    {
        [BsonId]
        [JsonIgnore]
        public Guid Id { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}

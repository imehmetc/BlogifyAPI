using BlogifyAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogifyAPI.Domain.Entities.Concrete
{
    public class Post : BaseEntity
    {
        public Post()
        {
            // Lazy loading
            Comments = new List<Comment>();
            Favorites = new List<Favorite>();
        }

		public Post(Guid authorId, Guid categoryId, string title, string content, string imageUrl = null, int likeCount = 0, int viewCount = 0)
		{
            // Required properties
			AuthorId = authorId;
			CategoryId = categoryId;
			Title = title;
			Content = content;
		}

		[Required]
		public required Guid AuthorId { get; set; }

		[Required]
		public required Guid CategoryId { get; set; }

		[Required]
		[MaxLength(100, ErrorMessage = "Title cannot exceed 100 characters.")]
		public required string Title { get; set; }

		[Required]
		[MinLength(10, ErrorMessage = "Content must be at least 10 characters long.")]
		public required string Content { get; set; }

		[Url(ErrorMessage = "Invalid Image URL format.")]
		public string ImageUrl { get; set; }

		[Range(0, int.MaxValue, ErrorMessage = "Like count cannot be negative.")]
		public int LikeCount { get; set; }

		[Range(0, int.MaxValue, ErrorMessage = "View count cannot be negative.")]
		public int ViewCount { get; set; }

		// Navigation Props
		public User Author { get; set; }
        public Category Category { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Favorite> Favorites { get; set; }
    }
}

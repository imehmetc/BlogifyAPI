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

		public Post(Guid authorId, string title, string content, string imageUrl = null, int likeCount = 0, int viewCount = 0)
		{
            // Required properties
			AuthorId = authorId;
			Title = title;
			Content = content;
		}

		public required Guid AuthorId { get; set; }
		public required string Title { get; set; }
		public required string Content { get; set; }
		public string ImageUrl { get; set; }
		public int LikeCount { get; set; }
		public int ViewCount { get; set; }

		// Navigation Props
		public virtual User Author { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Favorite> Favorites { get; set; }
		public virtual ICollection<PostCategory> PostCategories { get; set; }
	}
}

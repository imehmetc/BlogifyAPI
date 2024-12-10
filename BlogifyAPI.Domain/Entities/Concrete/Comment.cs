using BlogifyAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogifyAPI.Domain.Entities.Concrete
{
    public class Comment : BaseEntity
    {
        public Comment()
        {
            
        }

		public Comment(Guid postId, Guid userId, string content, bool isApproved)
        {
			PostId = postId;
			UserId = userId;
			Content = content;
			IsApproved = isApproved;
		}

		[Required]
		public required Guid PostId { get; set; }

		[Required]
		public required Guid UserId { get; set; }

		[Required]
		[StringLength(1000, MinimumLength = 5, ErrorMessage = "Content must be between 5 and 1000 characters.")]
		public required string Content { get; set; }

		[Required]
		public required bool IsApproved { get; set; }

        // Navigation Props
        public Post Post { get; set; }
        public User User { get; set; }
    }
}

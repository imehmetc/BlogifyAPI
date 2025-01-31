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
        public Comment() { }

		public Comment(Guid postId, Guid userId, string content, bool isApproved)
        {
			PostId = postId;
			UserId = userId;
			Content = content;
			IsApproved = isApproved;
		}

		public required Guid PostId { get; set; }
		public required Guid UserId { get; set; }
		public required string Content { get; set; }
		public required bool IsApproved { get; set; }

        // Navigation Props
        public virtual Post Post { get; set; }
        public virtual User User { get; set; }
    }
}

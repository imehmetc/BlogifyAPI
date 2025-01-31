using BlogifyAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogifyAPI.Domain.Entities.Concrete
{
	public class PostCategory : BaseEntity
	{
		public PostCategory() { }

		public PostCategory(Guid postId, Guid categoryId)
		{
			PostId = postId;
			CategoryId = categoryId;
		}

		public required Guid PostId { get; set; }
		public required Guid CategoryId { get; set; }

		// Navigation Props
		public Post Post { get; set; }
		public Category Category { get; set; }
	}
}

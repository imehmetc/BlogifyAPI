using BlogifyAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogifyAPI.Domain.Entities.Concrete
{
    public class Favorite : BaseEntity
    {
        public Favorite()
        {
            
        }

		public Favorite(Guid postId, Guid favoritedUserId)
        {
			PostId = postId;
			FavoritedUserId = favoritedUserId;
		}

		[Required]
		public required Guid PostId { get; set; }

		[Required]
		public required Guid FavoritedUserId { get; set; }

        // Navigation Props
        public Post Post { get; set; }
        public User User { get; set; }
    }
}

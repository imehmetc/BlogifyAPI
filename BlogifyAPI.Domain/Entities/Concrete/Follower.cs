using BlogifyAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogifyAPI.Domain.Entities.Concrete
{
    public class Follower : BaseEntity
    {
        public Follower()
        {
            
        }

        public Follower(Guid followerUserId, Guid followedUserId, DateTime followedDate)
        {
			FollowerUserId = followerUserId;
			FollowedUserId = followedUserId;
			FollowedDate = followedDate;
		}

		[Required]
		public required Guid FollowerUserId { get; set; }

		[Required]
		public required Guid FollowedUserId { get; set; }

		[Required]
		[DataType(DataType.Date)]
		public required DateTime FollowedDate { get; set; } = DateTime.Now;

		[DataType(DataType.Date)]
		public DateTime? UnfollowedDate { get; set; }

        // Navigation Props
        public User FollowerUser { get; set; }
        public User FollowedUser { get; set; }
    }
}

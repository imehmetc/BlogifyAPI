using BlogifyAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogifyAPI.Domain.Entities.Concrete
{
    public class Follower : BaseEntity
    {
        public Guid FollowerUserId { get; set; }
        public Guid FollowedUserId { get; set; }
        public DateTime FollowedDate { get; set; } = DateTime.Now;
        public DateTime? UnfollowedDate { get; set; }

        // Navigation Props
        public User FollowerUser { get; set; }
        public User FollowedUser { get; set; }
    }
}

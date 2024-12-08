using BlogifyAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogifyAPI.Domain.Entities.Concrete
{
    public class Favorite : BaseEntity
    {
        public Guid PostId { get; set; }
        public Guid FavoritedUserId { get; set; }

        // Navigation Props
        public Post Post { get; set; }
        public User User { get; set; }
    }
}

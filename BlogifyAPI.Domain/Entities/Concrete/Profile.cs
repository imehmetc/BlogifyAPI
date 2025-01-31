using BlogifyAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogifyAPI.Domain.Entities.Concrete
{
    public class Profile : BaseEntity
    {
        public Profile() { }

        public Profile(Guid userId)
        {
			// Required properties
			UserId = userId;
		}

		public required Guid UserId { get; set; }
		public string About { get; set; }
		public string TwitterUrl { get; set; }
		public string InstagramUrl { get; set; }
		public string LinkedinUrl { get; set; }
		public string Avatar { get; set; }

		// Navigation Props
		public virtual User User { get; set; }
    }
}

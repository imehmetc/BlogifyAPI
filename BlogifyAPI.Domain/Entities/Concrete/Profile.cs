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
        public Profile()
        {
            
        }

        public Profile(Guid userId)
        {
			// Required properties
			UserId = userId;
		}
		
		[Required]
		public required Guid UserId { get; set; }

		[MaxLength(250)]
		public string About { get; set; }

		[Url(ErrorMessage = "Invalid Twitter URL format.")]
		public string TwitterUrl { get; set; }

		[Url(ErrorMessage = "Invalid Instagram URL format.")]
		public string InstagramUrl { get; set; }

		[Url(ErrorMessage = "Invalid LinkedIn URL format.")]
		public string LinkedinUrl { get; set; }

		public string Avatar { get; set; }

		// Navigation Props
		public User User { get; set; }
    }
}

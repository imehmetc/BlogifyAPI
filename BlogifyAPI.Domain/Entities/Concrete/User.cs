using BlogifyAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogifyAPI.Domain.Entities.Concrete
{
    public class User : BaseEntity
    {
        public User()
        {
			// Lazy loading
			Posts = new List<Post>();
			Comments = new List<Comment>();
			Favorites = new List<Favorite>();
			Followers = new List<Follower>();
        }

		public User(string email, string password, string userName, string firstName, string lastName)
        {
			// Required properties
			Email = email;
			Password = password;
			UserName = userName;
			FirstName = firstName;
			LastName = lastName;
		}

		[Required, EmailAddress]
		public required string Email { get; set; }
		
		[Required, MinLength(8)]
		public required string Password { get; set; }
		
		[Required, MaxLength(50)]
		public required string UserName { get; set; }
		
		[MaxLength(100)]
		public required string FirstName { get; set; }
		
		[MaxLength(100)]
		public required string LastName { get; set; }

		public string FullName => $"{FirstName} {LastName}".Trim();

		[DataType(DataType.Date)]
		[Range(typeof(DateTime), "1/1/1900", "12/31/2099", ErrorMessage = "Birth date must be a valid date.")]
		public DateTime? BirthDate { get; set; }

		[DataType(DataType.Date)]
		public DateTime? LastLoginDate { get; set; }

      
		// Navigation Props
        public Profile? Profile { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Favorite> Favorites { get; set; }
        public ICollection<Follower> Followers { get; set; }
    }
}

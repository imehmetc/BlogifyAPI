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

		public required string Email { get; set; }
		public required string Password { get; set; }
		public required string UserName { get; set; }
		public required string FirstName { get; set; }
		public required string LastName { get; set; }
		public string FullName => $"{FirstName} {LastName}".Trim();
		public DateTime? BirthDate { get; set; }
		public DateTime? LastLoginDate { get; set; }

      
		// Navigation Props
        public virtual Profile? Profile { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Favorite> Favorites { get; set; }
	}
}

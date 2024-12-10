using BlogifyAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogifyAPI.Domain.Entities.Concrete
{
    public class Category : BaseEntity
    {
        public Category()
        {
            Posts = new List<Post>();
        }

        public Category(int parentId, string name, int priority, string description )
        {
			ParentId = parentId;
			Name = name;
			Priority = priority;
			Description = description;
		}

		[Required]
		public required int ParentId { get; set; }

		[Required]
		[StringLength(100, MinimumLength = 3, ErrorMessage = "The category name must be between 3 and 100 characters.")]
		public required string Name { get; set; }

		[Required]
		[StringLength(250, ErrorMessage = "The description cannot exceed 250 characters.")]
		public required string Description { get; set; }

		[Required]
		public required int Priority { get; set; }

        // Navigation Props
        public ICollection<Post> Posts { get; set; }
    }
}

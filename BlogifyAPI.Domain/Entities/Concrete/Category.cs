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
        public Category() { }

        public Category(string name)
        {
			Name = name;
		}

		public required string Name { get; set; }

		// Navigation Props
		public virtual ICollection<PostCategory> PostCategories { get; set; }
	}
}

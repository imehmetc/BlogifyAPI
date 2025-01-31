using BlogifyAPI.Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogifyAPI.Persistence.Configurations
{
	public class PostCategoryConfiguration : IEntityTypeConfiguration<PostCategory>
	{
		public void Configure(EntityTypeBuilder<PostCategory> builder)
		{
			throw new NotImplementedException();
		}
	}
}

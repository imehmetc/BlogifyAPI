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
	public class PostConfiguration : IEntityTypeConfiguration<Post>
	{
		public void Configure(EntityTypeBuilder<Post> builder)
		{
			builder.Property(x => x.AuthorId).IsRequired();

			builder.Property(x => x.Title)
				.IsRequired()
				.HasMaxLength(100)
				.HasAnnotation("ErrorMessage", "Title cannot exceed 100 characters.");

			builder.Property(x => x.Content).IsRequired();
		}
	}
}

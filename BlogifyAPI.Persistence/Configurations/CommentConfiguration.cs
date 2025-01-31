using BlogifyAPI.Domain.Entities.Concrete;
using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogifyAPI.Persistence.Configurations
{
	public class CommentConfiguration : IEntityTypeConfiguration<Comment>
	{
		public void Configure(EntityTypeBuilder<Comment> builder)
		{
			builder.Property(x => x.PostId).IsRequired();
			
			builder.Property(x => x.UserId).IsRequired();
			
			builder.Property(x => x.Content)
				.HasMaxLength(1000)
				.IsRequired()
				.HasAnnotation("ErrorMessage", "Content must be 1000 character.");

			builder.Property(x => x.IsApproved).IsRequired();
		}
	}
}

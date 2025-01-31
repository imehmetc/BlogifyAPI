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
	public class CategoryConfiguration : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			builder.Property(x => x.Name)
				.IsRequired()
				.HasMaxLength(100)
				.HasAnnotation("ErrorMessage", "The category name must be between 3 and 100 characters.");

			builder.HasIndex(x => x.Name).IsUnique();

			// Seed Data with Bogus
			Category category1 = new()
			{
				Id = Guid.NewGuid(),
				Name = "All Categories",
			};

			Category category2 = new()
			{
				Id = Guid.NewGuid(),
				Name = "Software",
			};

			Category category3 = new()
			{
				Id = Guid.NewGuid(),
				Name = "Finance",
			};

			Category category4 = new()
			{
				Id = Guid.NewGuid(),
				Name = "Finance",
				IsDeleted = true,
				DeletedDate = DateTime.Now,
				Status = Domain.Enums.EntityStatus.Deleted
			};

			builder.HasData(category1, category2, category3, category4);
		}
	}
}

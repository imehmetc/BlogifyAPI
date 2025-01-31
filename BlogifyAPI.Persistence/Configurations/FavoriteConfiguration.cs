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
	public class FavoriteConfiguration : IEntityTypeConfiguration<Favorite>
	{
		public void Configure(EntityTypeBuilder<Favorite> builder)
		{
			builder.Property(x => x.PostId).IsRequired();

			builder.Property(x => x.FavoritedUserId).IsRequired();
		}
	}
}

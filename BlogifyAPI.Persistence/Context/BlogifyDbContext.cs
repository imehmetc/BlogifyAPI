using BlogifyAPI.Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BlogifyAPI.Persistence.Context
{
	public class BlogifyDbContext : DbContext
	{
		public BlogifyDbContext(DbContextOptions<BlogifyDbContext> options) : base(options) { }

		public DbSet<User> Users { get; set; }
		public DbSet<Post> Posts { get; set; }
		public DbSet<Profile> Profiles { get; set; }
		public DbSet<Favorite> Favorites { get; set; }
		public DbSet<Comment> Comments { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<PostCategory> PostCategories { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseLazyLoadingProxies();
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			//modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); // Konfigürasyon dosyalarının tanımlanması.
		}
	}
}

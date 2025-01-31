using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogifyAPI.Persistence.Context
{
	public class BlogifyDbContextFactory : IDesignTimeDbContextFactory<BlogifyDbContext>
	{
		public BlogifyDbContext CreateDbContext(string[] args)
		{
			// Ortam bilgisini al
			string environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Development";

			// Yapılandırmayı oluştur
			IConfigurationRoot configuration = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json", optional: false)
				.AddJsonFile($"appsettings.{environment}.json", optional: true)
				.Build();

			// DbContext ayarlarını oluştur
			var optionsBuilder = new DbContextOptionsBuilder<BlogifyDbContext>();
			optionsBuilder.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));

			return new BlogifyDbContext(optionsBuilder.Options);
		}
	}
}

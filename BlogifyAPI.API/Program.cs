using BlogifyAPI.Persistence;
using BlogifyAPI.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace BlogifyAPI.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var env = builder.Environment; // Seçilen "Development" veya "Production" isimlerini alır

			builder.Configuration
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false) // appsettings her zaman okunacağı için optional:false
				.AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true); // hangi ortamdaysa o ortamın appsettings dosyasını alır. (appsettings.Development.json ..)

           
            string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
			builder.Services.AddDbContext<BlogifyDbContext>(options =>
	            options.UseNpgsql(connectionString));
			
            // Add services to the container.
			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();


			var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}

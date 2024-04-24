using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPages_AlbumProject.Data;
namespace RazorPages_AlbumProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<RazorPages_AlbumProjectContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("RazorPages_AlbumProjectContext") ?? throw new InvalidOperationException("Connection string 'RazorPages_AlbumProjectContext' not found.")));

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddTransient<IAlbum, AlbumRepository>();
            builder.Services.AddTransient<ISong, SongRepository>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
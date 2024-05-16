using AnonymousBlog.Ui.Components;
using AnonymousBlog.Ui.Data;

using Microsoft.EntityFrameworkCore;

namespace AnonymousBlog.Ui
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<AnonymousBlogContext>(options =>
                options.UseNpgsql(builder.Configuration.GetConnectionString("DevConnection") ?? throw new InvalidOperationException("Connection string 'AnonymousBlogContext' not found.")));

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

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
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebTest.Interface;
using WebTest.Model;
using WebTest.Repository;
using WebTest.Service;

namespace WebTest
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = Configuration.GetConnectionString("DefaultConnection"); // Use the correct connection string name
            services.AddDbContext<AuthDbContext>(options =>
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
            );

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<AuthDbContext>();
            services.AddRazorPages();

            services.ConfigureApplicationCookie(config =>
            {
                config.LoginPath = "/Login";
            });

            services.AddScoped<IPontoService, PontoService>();
            services.AddScoped<IPontoRepository, PontoRepository>(); 

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}

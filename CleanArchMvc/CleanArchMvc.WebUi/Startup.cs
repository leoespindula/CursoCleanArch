using CleanArchMvc.Domain.Account;
using CleanArchMvc.Infra.Ioc;

namespace CleanArchMvc.WebUi
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
            services.AddInfrastructure(Configuration);
            services.AddControllersWithViews();
        }

        public void Configure(WebApplication app, IWebHostEnvironment environment, ISeedUserRoleInitial seedUserRoleInitial) 
        {
            if (environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else 
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            seedUserRoleInitial.SeedRoles();
            seedUserRoleInitial.SeedUsers();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        }

    }
}

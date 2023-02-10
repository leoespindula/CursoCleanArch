using CleanArchMvc.Infra.Ioc;
using Microsoft.OpenApi.Models;

namespace CleanArchMvc.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration) 
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get;}
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddInfrastructureAPI(Configuration);
            services.AddInfrastructureJWT(Configuration);
            services.AddControllers();

            services.AddEndpointsApiExplorer();
            services.AddInfrastructureSwagger();
        }
        public void Configure(WebApplication app, IWebHostEnvironment enviroment)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseStatusCodePages();
            app.UseRouting();
            app.UseAuthentication();

            app.UseAuthorization();


            app.MapControllers();
        }
    }
}

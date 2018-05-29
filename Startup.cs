using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangfire;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.Webpack;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using presurgeryapp.IoC;

namespace presurgeryapp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<Models.ApplicationDbContext>(options => 
                options.UseSqlServer("Server=.;Database=presurgeryapp.Models;Trusted_Connection=True;MultipleActiveResultSets=true")
            );
            
            services.AddHangfire(x => x.UseSqlServerStorage("Server=.;Database=presurgeryapp.Models;Trusted_Connection=True;MultipleActiveResultSets=true; Integrated Security=SSPI"));
            services.AddMvc();
        }
        
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider serviceProvider, Models.ApplicationDbContext applicationDbContext)
        {
            IocContainer.Provider = (ServiceProvider)serviceProvider;
            applicationDbContext.Database.EnsureCreated();

            app.UseHangfireDashboard("/hangfire");
            app.UseHangfireServer();

            app.UseDeveloperExceptionPage();
            app.UseWebpackDevMiddleware(new WebpackDevMiddlewareOptions
            {
                HotModuleReplacement = true,
                ReactHotModuleReplacement = true
            });

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapSpaFallbackRoute(
                    name: "spa-fallback",
                    defaults: new { controller = "Home", action = "Index" });
            });
        }
    }
}

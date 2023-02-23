using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Card
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
            //for using the views.cshtml and routing to that views with controller and actions
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
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
            //To use routing in the program
            app.UseRouting();

            app.UseAuthorization();

            #region Routing_TemplateRoutingOrConventionBaseRoute
            // 2 example of routing
            
            //app.UseEndpoints(endpointmiddleware =>
            //{
            //    endpointmiddleware.MapControllerRoute(
            //        "controllerActionProduct",
            //        "{controller=Home}/{action=contact}/{product?}");
            //});

            // app.UseEndpoints(myTemplateRout =>
            //{
            //    myTemplateRout.MapControllerRoute(
            //        "myRout",
            //        "{action},{controller}.{id?}"
            //    );
            //}); 


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            #endregion


        }
    }
}

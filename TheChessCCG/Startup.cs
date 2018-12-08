using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using TheChessCCG.Models;


namespace TheChessCCG
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            var connection = "server=thechessccgdbserver.database.windows.net;Initial Catalog=ChessCCG;User ID=BigTrashBear;Password='Schorpioen(94);';Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(connection);
            });

            services.AddMvc();
            /*services.Configure<RazorViewEngineOptions>(options =>
            {
                options.AreaViewLocationFormats.Clear();
                options.AreaViewLocationFormats.Add("/General/{2}/Views/{1}/{0}.cshtml");
                options.AreaViewLocationFormats.Add("/Game/{2}/Views/{1}/{0}.cshtml");
            });*/
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else { app.UseHsts(); }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();

            app.UseMvc(routes =>
            {

            routes.MapAreaRoute(
                name: "VanPiereArea",
                areaName: "VanPiereRoosters",
                template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

            routes.MapAreaRoute(
                name: "vanPiereDefault",
                areaName: "VanPiereRoosters",
                template: "{controller=Home}/{action=Index}/{id?}");

            routes.MapAreaRoute(
              name: "generalArea",
              areaName: "General",
              template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

            routes.MapAreaRoute(
              name: "generalDefault",
              areaName: "General",
              template: "{controller=Home}/{action=Index}/{id?}");

            routes.MapAreaRoute(
              name: "gameArea",
              areaName: "Game",
              template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

            routes.MapAreaRoute(
                  name: "gameDefault",
                  areaName: "Game",
                  template: "{controller=Home}/{action=Index}/{id?}");
            });
            
        }
    }
}

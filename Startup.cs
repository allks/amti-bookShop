using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using amti_bookShop.Data.Interfaces;
using amti_bookShop.Data.Mocks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace amti_bookShop
{
    public class Startup {
        public void ConfigureServices(IServiceCollection services) {
            services.AddTransient<IAllBooks, MockBooks>();
            services.AddTransient<IBooksCategory, MockCategory>();
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}

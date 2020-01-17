using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using amti_bookShop.Data;
using amti_bookShop.Data.Interfaces;
using amti_bookShop.Data.Mocks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace amti_bookShop {
	public class Startup {
		private IConfigurationRoot _confSting;

		[Obsolete]
		public Startup(IHostingEnvironment hostEnv) {
			_confSting = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
		}
		public void ConfigureServices(IServiceCollection services) {
			services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confSting.GetConnectionString("DefaultConnection")));
			services.AddTransient<IAllBooks, MockBooks>();
			services.AddTransient<IBooksCategory, MockCategory>();
			services.AddMvc();
			services.AddMvc(options => options.EnableEndpointRouting = false);
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
			app.UseDeveloperExceptionPage();
			app.UseStatusCodePages();
			app.UseStaticFiles();
			app.UseMvcWithDefaultRoute();
		}
	}
}

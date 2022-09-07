using Autofac;
using GZY.Quartz.MUI.EFContext;
using GZY.Quartz.MUI.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bucket.Quartz.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureContainer(ContainerBuilder builder)
        {
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddRazorPages();
            //services.AddControllers();
            string connectionString = Configuration.GetSection("ConnectionStringsMySql").Value;
            var optionsBuilder = new DbContextOptionsBuilder<QuarzEFContext>();
            optionsBuilder.UseMySql<QuarzEFContext>(connectionString, ServerVersion.Parse("5.7.39"),b => b.MaxBatchSize(1));
            services.AddQuartzUI(optionsBuilder.Options);
            services.AddQuartzClassJobs();
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseQuartz();
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllers();
            //});


            //app.UseEndpoints(endpoints => {
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("hello");
            //    });
            //});


            //app.UseAuthorization();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapRazorPages();
            //});
        }
    }
}

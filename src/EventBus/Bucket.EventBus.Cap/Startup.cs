using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bucket.MongoDbContext;
using Bucket.DapperContext;
using Bucket.EventBus.Cap.Filters;
using Bucket.EventBus.Cap.Services;

namespace Bucket.EventBus.Cap
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
            services.AddTransient<ISubscriberService, SubscriberService>();
            //services.AddRazorPages();
            services.AddMvc();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Bucket.EventBus.Cap", Version = "v1" });
            });
            services.AddCap(x =>
            {
                // If you are using ADO.NET, choose to add configuration you needed：
                x.UseMySql(Configuration["Cap:Db:Con"].ToString());

                // CAP support RabbitMQ,Kafka,AzureService as the MQ, choose to add configuration you needed：
                //x.UseRabbitMQ(Configuration["Cap:Mq:Con"].ToString());
                x.UseRabbitMQ(options =>
                {
                    //上一篇中我创建的用户名密码 
                    options.HostName = "192.168.192.129";
                    options.UserName = "admin";
                    options.Password = "admin";
                    options.VirtualHost = "/";
                });
            }).AddSubscribeFilter<CapSubscribeFilter>();
            //services.AddMongoDbContext(section: "MongoDbConfig")
            //    .AddMongoDbRepository();
            //services.AddDapperDbContext(section: "DapperDbConfig")
            //    .AddDapperDbRepository();
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
            if (!env.IsProduction())
            {
                app.UseSwagger(options =>
                {
                    options.RouteTemplate = "/swagger/{documentName}/swagger.json";
                });
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Bucket.EventBus.Cap v1");
                });
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapRazorPages();
                //endpoints.MapSwagger();
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}

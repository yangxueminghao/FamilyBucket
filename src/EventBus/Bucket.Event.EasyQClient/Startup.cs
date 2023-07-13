using Bucket.Event.EasyNetQClient.Extensions;
using Bucket.Event.EasyQClient.BackJob;
using Bucket.Event.EasyQClient.RedisSubscribe;
using EasyNetQ;
using InitQ;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerUI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Bucket.Event.EasyQClient
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
            services.AddMvc();
            #region swagger
            services.AddSwaggerGen(c =>
            {
                //c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "ErsApi.Entity.xml"), true);
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "EasyQClient", Version = "V1", Description = "EasyQClient Description" });
                var xmlFile = $"{Assembly.GetEntryAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath, true);

            });
            #endregion

            string rabbitMqConnection = Configuration["RabbitMqConnection"];
            services.AddSingleton(RabbitHutch.CreateBus(rabbitMqConnection, x => x.EnableDelayedExchangeScheduler()));
            services.AddHostedService<ConsumeJob>();
            //services.AddHostedService<ConsumeJobA>();
            //services.AddHostedService<ConsumeJobB>();
            //services.AddHostedService<ConsumeJobC>();

            //services.AddInitQ(m =>
            //{
            //    m.SuspendTime = 1000;
            //    m.ConnectionString = "192.168.192.130:6379,password=admin";
            //    m.ListSubscribe = new List<Type>() { typeof(RedisDelaySubscribe)};
            //    m.ShowLog = false;
            //});
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
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint($"/swagger/v1/swagger.json", "V1");
                c.DocExpansion(DocExpansion.None);
            });
            //app.UseSubscribe("OrderService", Assembly.GetExecutingAssembly());
            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapRazorPages();
                endpoints.MapDefaultControllerRoute();
            });
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapRazorPages();
            //});
            
        }
    }
}

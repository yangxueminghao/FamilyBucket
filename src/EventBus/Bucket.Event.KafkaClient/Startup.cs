using Autofac;
//using Bucket.Event.Kafka;
using Bucket.Event.KafkaClient.Extensions;
using Confluent.Kafka;
using EasyNetQ;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
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

namespace Bucket.Event.KafkaClient
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
            //services.AddRazorPages();

            services.AddMvc();
            services.Configure<ProducerConfig>(Configuration.GetSection("ProducerConfig"));
            services.AddOptions().Configure<ConsumerConfig>(e => Configuration.GetSection("ConsumerConfig").Bind(e));
            string rabbitMqConnection = Configuration["RabbitMqConnection"];
            services.AddScoped<IBus>(s => RabbitHutch.CreateBus(rabbitMqConnection, x => x.EnableDelayedExchangeScheduler()));
            #region swagger
            services.AddSwaggerGen(c =>
            {
                //c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "ErsApi.Entity.xml"), true);
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "KafkaClient", Version = "V1", Description = "KafkaClient Description" });
                var xmlFile = $"{Assembly.GetEntryAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath, true);

            });
            #endregion
        }
        public void ConfigureContainer(ContainerBuilder builder)
        {
            //builder.RegisterType<KafkaProducerFactory<StandProducer<string, string>>>().As<IKafkaProducerFactory<StandProducer<string, string>>>();
            //builder.RegisterType<KafkaConsumerFactory<StandConsumer<string, string>>>().As<IKafkaConsumerFactory<StandConsumer<string, string>>>();

            //builder.RegisterType<KafkaProducerManager>().AsSelf();
            //builder.RegisterType<KafkaConsumerManager>().AsSelf();
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

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint($"/swagger/v1/swagger.json", "V1");
                c.DocExpansion(DocExpansion.None);
            });

            app.UseAuthorization();
            //app.UseSubscribe("OrderService", Assembly.GetExecutingAssembly());
            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapRazorPages();
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}

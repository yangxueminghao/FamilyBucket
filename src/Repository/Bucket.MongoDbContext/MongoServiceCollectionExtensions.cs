using Bucket.DependencyInjection;
using Bucket.MongoDbContext.Mongo;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace Bucket.MongoDbContext
{
    public static class MongoServiceCollectionExtensions
    {
        /// <summary>
        /// 添加Mongo多数据库支持
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <param name="contextLifetime"></param>
        /// <param name="section"></param>
        /// <returns></returns>
        public static IServiceCollection AddMongoDbContext(this IServiceCollection services, IConfiguration configuration, ServiceLifetime contextLifetime = ServiceLifetime.Scoped, string section = "MongoDbConfig")
        {
            var connectOptions = new MongoDbConnectOption();
            connectOptions.DbName=configuration.GetSection(section)["DbName"];
            connectOptions.Host = configuration.GetSection(section)["Host"];
            connectOptions.Port = int.Parse(configuration.GetSection(section)["Port"]);
            if (connectOptions != null)
            {
                if (contextLifetime == ServiceLifetime.Scoped)
                    services.AddScoped(s => new BucketMongoClient(connectOptions));
                if (contextLifetime == ServiceLifetime.Singleton)
                    services.AddSingleton(s => new BucketMongoClient(connectOptions));
                if (contextLifetime == ServiceLifetime.Transient)
                    services.AddTransient(s => new BucketMongoClient(connectOptions));
                if (contextLifetime == ServiceLifetime.Singleton)
                    services.AddSingleton<IMongoDbContextFactory, MongoDbContextFactory>();
                if (contextLifetime == ServiceLifetime.Scoped)
                    services.AddScoped<IMongoDbContextFactory, MongoDbContextFactory>();
                if (contextLifetime == ServiceLifetime.Transient)
                    services.AddTransient<IMongoDbContextFactory, MongoDbContextFactory>();
            }
            return services;
        }

        /// <summary>
        /// 添加Mongo多数据库支持
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="contextLifetime"></param>
        /// <param name="section"></param>
        /// <returns></returns>
        public static IServiceCollection AddMongoDbContext(this IBucketBuilder builder, ServiceLifetime contextLifetime = ServiceLifetime.Scoped, string section = "DbConfig")
        {
            return AddMongoDbContext(builder.Services, builder.Configuration, contextLifetime, section);
        }

        /// <summary>
        /// 添加Mongo多数据库支持
        /// </summary>
        /// <param name="services"></param>
        /// <param name="contextLifetime"></param>
        /// <param name="section"></param>
        /// <returns></returns>
        public static IServiceCollection AddMongoDbContext(this IServiceCollection services, ServiceLifetime contextLifetime = ServiceLifetime.Scoped, string section = "DbConfig")
        {
            var service = services.First(x => x.ServiceType == typeof(IConfiguration));
            var configuration = (IConfiguration)service.ImplementationInstance;
            if (configuration==null)
            {
                var singletonObject = service.ImplementationFactory.Invoke(services.BuildServiceProvider());
                configuration = (IConfiguration)singletonObject;
            }
            
            return AddMongoDbContext(services, configuration, contextLifetime, section);
        }

        /// <summary>
        /// 添加Mongo数据仓储,依赖AddMongoDbContext
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddMongoDbRepository(this IServiceCollection services, ServiceLifetime contextLifetime = ServiceLifetime.Scoped)
        {
            if (contextLifetime == ServiceLifetime.Singleton)
                services.AddSingleton(typeof(IMongoDbRepository<>), typeof(MongoDbRepository<>));
            if (contextLifetime == ServiceLifetime.Scoped)
                services.AddScoped(typeof(IMongoDbRepository<>), typeof(MongoDbRepository<>));
            if (contextLifetime == ServiceLifetime.Transient)
                services.AddTransient(typeof(IMongoDbRepository<>), typeof(MongoDbRepository<>));
            services.AddSingleton<IMongoDbRepositoryFactory, MongoDbRepositoryFactory>();
            return services;
        }
    }
}

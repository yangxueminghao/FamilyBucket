using Bucket.DapperContext.Dapper;
using Bucket.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;

namespace Bucket.DapperContext
{
    public static class DapperServiceCollectionExtensions
    {
        /// <summary>
        /// 添加Dapper多数据库支持
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <param name="contextLifetime"></param>
        /// <param name="section"></param>
        /// <returns></returns>
        public static IServiceCollection AddDapperDbContext(this IServiceCollection services, IConfiguration configuration, ServiceLifetime contextLifetime = ServiceLifetime.Scoped, string section = "DapperDbConfig")
        {
            var connectOptions = configuration.GetSection(section).Get<DapperOption>();
            if (connectOptions != null)
            {

                if (contextLifetime == ServiceLifetime.Scoped)
                    services.AddScoped<IDbConnection>(s =>
                    {
                        if (connectOptions.DbType == DbTypeEnum.Mysql)
                        {
                            return new MySqlConnection(connectOptions.ConStr);
                        }
                        else { throw new ArgumentException("暂不支持非Mysql数据库！"); }

                    });
                if (contextLifetime == ServiceLifetime.Singleton)
                    services.AddScoped<IDbConnection>(s =>
                    {
                        if (connectOptions.DbType == DbTypeEnum.Mysql)
                        {
                            return new MySqlConnection(connectOptions.ConStr);
                        }
                        else { throw new ArgumentException("暂不支持非Mysql数据库！"); }

                    });
                if (contextLifetime == ServiceLifetime.Transient)
                    services.AddScoped<IDbConnection>(s =>
                    {
                        if (connectOptions.DbType == DbTypeEnum.Mysql)
                        {
                            return new MySqlConnection(connectOptions.ConStr);
                        }
                        else { throw new ArgumentException("暂不支持非Mysql数据库！"); }

                    });

                //if (contextLifetime == ServiceLifetime.Singleton)
                //    services.AddSingleton<IDapperDbContextFactory, DapperDbContextFactory>();
                //if (contextLifetime == ServiceLifetime.Scoped)
                //    services.AddScoped<IDapperDbContextFactory, DapperDbContextFactory>();
                //if (contextLifetime == ServiceLifetime.Transient)
                //    services.AddTransient<IDapperDbContextFactory, DapperDbContextFactory>();
            }
            return services;
        }

        /// <summary>
        /// 添加Dapper多数据库支持
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="contextLifetime"></param>
        /// <param name="section"></param>
        /// <returns></returns>
        public static IServiceCollection AddDapperDbContext(this IBucketBuilder builder, ServiceLifetime contextLifetime = ServiceLifetime.Scoped, string section = "DapperDbConfig")
        {
            return AddDapperDbContext(builder.Services, builder.Configuration, contextLifetime, section);
        }

        /// <summary>
        /// 添加Dapper多数据库支持
        /// </summary>
        /// <param name="services"></param>
        /// <param name="contextLifetime"></param>
        /// <param name="section"></param>
        /// <returns></returns>
        public static IServiceCollection AddDapperDbContext(this IServiceCollection services, ServiceLifetime contextLifetime = ServiceLifetime.Scoped, string section = "DapperDbConfig")
        {
            var service = services.First(x => x.ServiceType == typeof(IConfiguration));
            var configuration = (IConfiguration)service.ImplementationInstance;
            return AddDapperDbContext(services, configuration, contextLifetime, section);
        }

        /// <summary>
        /// 添加Dapper数据仓储,依赖AddDapperDbContext
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddDapperDbRepository(this IServiceCollection services, ServiceLifetime contextLifetime = ServiceLifetime.Scoped)
        {
            if (contextLifetime == ServiceLifetime.Singleton)
                services.AddSingleton(typeof(IDapperDbRepository<>), typeof(DapperDbRepository<>));
            if (contextLifetime == ServiceLifetime.Scoped)
                services.AddScoped(typeof(IDapperDbRepository<>), typeof(DapperDbRepository<>));
            if (contextLifetime == ServiceLifetime.Transient)
                services.AddTransient(typeof(IDapperDbRepository<>), typeof(DapperDbRepository<>));
            //services.AddSingleton<IDapperDbRepositoryFactory, DapperDbRepositoryFactory>();
            return services;
        }
    }
}

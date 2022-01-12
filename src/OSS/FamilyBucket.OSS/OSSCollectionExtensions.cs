using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnceMi.AspNetCore.OSS;
using System;


namespace FamilyBucket.OSS
{
    public static class OSSCollectionExtensions
    {
        /// <summary>
        /// 添加Mongo多数据库支持
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <param name="contextLifetime"></param>
        /// <param name="section"></param>
        /// <returns></returns>
        public static IServiceCollection AddOSS(this IServiceCollection services,string section = "OSSProvider")
        {
            services.AddOSSService(section);

            return services;
        }

    }
}

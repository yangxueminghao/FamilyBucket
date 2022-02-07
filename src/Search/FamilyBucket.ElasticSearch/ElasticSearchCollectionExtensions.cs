using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nest;
using System;

namespace FamilyBucket.ElasticSearch
{
    public static class ElasticSearchCollectionExtensions
    {
        /// <summary>
        /// 添加ElasticSearch数据库支持
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <param name="contextLifetime"></param>
        /// <param name="section"></param>
        /// <returns></returns>
        public static IServiceCollection AddElasticSearch(this IServiceCollection services, string section = "ElasticSearchProvider")
        {
            services.AddScoped<IElasticClient>(sp=> {
                IConfiguration configuration = sp.GetRequiredService<IConfiguration>();
                //ElasticOption elasticOption = configuration.GetSection(section);
                return new ElasticClient(new Uri(configuration.GetSection($"{section}:url").Value));//nuget版本与elasticsearch版本一致
                
            });

            return services;
        }
    }
}

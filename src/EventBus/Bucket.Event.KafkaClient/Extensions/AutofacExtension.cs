using System.Linq;
using System.Runtime.Loader;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyModel;
using Microsoft.Extensions.Hosting;

namespace Bucket.Event.KafkaClient.Extensions
{
    public static class AutofacExtension
    {
        public static IHostBuilder UseAutofac(this IHostBuilder host)
        {
            host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
            host.ConfigureContainer<ContainerBuilder>(container =>
            {
                var libs = DependencyContext.Default.CompileLibraries.Where(lib => lib.Serviceable == false && lib.Type == "project").Select(lib => lib.Name).ToList();

                var assemblies = libs.Select(lib => AssemblyLoadContext.Default.LoadFromAssemblyName(new System.Reflection.AssemblyName(lib))).ToArray();

                //container
                //    .RegisterAssemblyTypes(assemblies)
                //    .Where(type => type.IsAbstract == false && type.IsAssignableTo(typeof(ISingletonIocTag)))
                //    .AsSelf()
                //    .AsImplementedInterfaces()
                //    .SingleInstance()
                //    .PropertiesAutowired();

                //container
                //    .RegisterAssemblyTypes(assemblies)
                //    .Where(type => type.IsAbstract == false && type.IsAssignableTo(typeof(IScopedIocTag)))
                //    .AsSelf()
                //    .AsImplementedInterfaces()
                //    .InstancePerLifetimeScope()
                //    .PropertiesAutowired();

                //container
                //    .RegisterAssemblyTypes(assemblies)
                //    .Where(type => type.IsAbstract == false && type.IsAssignableTo(typeof(ITransientIocTag)))
                //    .AsSelf()
                //    .AsImplementedInterfaces()
                //    .InstancePerDependency()
                //    .PropertiesAutowired();

                //container
                //    .RegisterAssemblyTypes(assemblies)
                //    .Where(type => type.IsAbstract == false && type.IsAssignableTo(typeof(ControllerBase)))
                //    .AsSelf()
                //    .InstancePerDependency()
                //    .PropertiesAutowired();
            });

            return host;
        }
    }

}

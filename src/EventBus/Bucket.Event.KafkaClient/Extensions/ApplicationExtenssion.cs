using Bucket.EventBus.Model;
using EasyNetQ;
using EasyNetQ.AutoSubscribe;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Bucket.Event.KafkaClient.Extensions
{
    public static class ApplicationExtenssion
    {
        public static IApplicationBuilder UseSubscribe(this IApplicationBuilder appBuilder, string subscriptionIdPrefix, Assembly assembly)
        {
            var services = appBuilder.ApplicationServices.CreateScope().ServiceProvider;

            var lifeTime = services.GetService<IHostApplicationLifetime>();
            var bus = services.GetService<IBus>();
            lifeTime.ApplicationStarted.Register(() =>
            {
                var subscriber = new AutoSubscriber(bus, subscriptionIdPrefix);
                subscriber.Subscribe(new Assembly[] { assembly });
                subscriber.SubscribeAsync(new Assembly[] { assembly });
            });

            lifeTime.ApplicationStopped.Register(() => { bus.Dispose(); });

            return appBuilder;
        }
        public static IApplicationBuilder UsePush(this IApplicationBuilder appBuilder)
        {
            var services = appBuilder.ApplicationServices.CreateScope().ServiceProvider;

            var lifeTime = services.GetService<IHostApplicationLifetime>();
            var bus = services.GetService<IBus>();
            lifeTime.ApplicationStarted.Register(() =>
            {
                var strList = new List<string>();

                try
                {
                    var exchange1 = bus.Advanced.ExchangeDeclare("Ers.EventBus.StudentEx", "topic");
                    var queue1 = bus.Advanced.QueueDeclare("Ers.EventBus.queue1");
                    var queue2 = bus.Advanced.QueueDeclare("Ers.EventBus.queue2");
                    var queue3 = bus.Advanced.QueueDeclare("Ers.EventBus.queue3");
                    bus.Advanced.Bind(exchange1, queue1, "Ers.*.Student");
                    bus.Advanced.Bind(exchange1, queue2, "Ers.#");
                    bus.Advanced.Bind(exchange1, queue3, "Ers.a.Student");
                    for (int i = 0; i < 100; i++)
                    {
                        // 以下是测试发送消息的代码
                        int sec = new Random(i).Next(100, 5000);
                        var msg = sec.ToString();
                        StudentMessage studentMessage = new StudentMessage { Id = sec, Name = $"张{msg}" };
                        try
                        {
                            bus.Advanced.Publish<StudentMessage>(exchange1, "Ers.b.Student", false, new Message<StudentMessage>(studentMessage));
                            //throw new Exception("fgksdfgioerterwpoyier");
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine($"{ex.Message}");
                        }


                        Debug.WriteLine($"{DateTimeOffset.Now.ToUnixTimeMilliseconds()} 发送成功 {msg}");
                        strList.Add(msg);
                    }
                }
                catch (Exception e)
                {

                    Debug.WriteLine($"{e.Message}");
                }
                finally
                {
                    bus.Dispose();
                }


            });

            lifeTime.ApplicationStopped.Register(() => { bus.Dispose(); });

            return appBuilder;
        }
    }
}

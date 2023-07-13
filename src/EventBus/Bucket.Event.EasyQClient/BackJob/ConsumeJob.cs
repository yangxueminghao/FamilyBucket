using EasyNetQ;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Bucket.EventBus.Model;
using RabbitMQ.Client.Events;
using System.Text;
using RabbitMQ.Client;
using System.Reflection;
using EasyNetQ.Consumer;

namespace Bucket.Event.EasyQClient.BackJob
{
    public class ConsumeJob : IHostedService, IDisposable
    {
        private IBus bus;
        private Timer _timer;
        public ConsumeJob(IBus _bus)
        {
            bus = _bus;
        }


        public Task StartAsync(CancellationToken cancellationToken)
        {
            //_timer = new Timer(DoWorkConfirm, null, TimeSpan.Zero, TimeSpan.FromSeconds(5));
            //DoWork(null);
            //DoWork2(null);
            //DoWork3(null);
            //DoWorkConfirm(null);
            DoWorkQos(null);
            return Task.CompletedTask;
        }

        private void DoWork(object? state)
        {
            var strList = new List<string>();
            // 创建普通队列，设置好 RoutingKey
            // 和第二步 MsgProducer 项目中的普通队列名称一致！！！
            var qNormal = bus.Advanced.QueueDeclare("Ers_normal_queue");

            bus.Advanced.Consume<int>(qNormal, (msg, msgInfo) =>
            {
                strList.Add($"{DateTimeOffset.Now} 收到消息：{msg.Body}");
                Debug.WriteLine($"{DateTimeOffset.Now} 收到消息：{msg.Body}");

            });

            Debug.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss}");
        }

        private void DoWork2(object? state)
        {
            var strList = new List<string>();
            // 创建普通队列，设置好 RoutingKey
            // 和第二步 MsgProducer 项目中的普通队列名称一致！！！
            //var qNormal = bus.Advanced.QueueDeclare("StudentMessage");

            bus.PubSub.Subscribe<StudentMessage>("StudentMessage", async (msg) =>
            {
                strList.Add($"{DateTimeOffset.Now.ToUnixTimeMilliseconds()} 收到消息：{msg}");
                Debug.WriteLine($"{DateTimeOffset.Now.ToUnixTimeMilliseconds()} 收到消息：{msg}");
                await Task.CompletedTask;
            });

            Debug.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss}");
        }

        private void DoWork3(object? state)
        {
            var strList = new List<string>();
            // 创建普通队列，设置好 RoutingKey
            // 和第二步 MsgProducer 项目中的普通队列名称一致！！！
            //var qNormal = bus.Advanced.QueueDeclare("StudentMessage");

            bus.PubSub.Subscribe<StudentMessage>("StudentMessage", async (msg) =>
            {
                strList.Add($"{DateTimeOffset.Now} 收到消息：{msg.Name}");
                Debug.WriteLine($"{DateTimeOffset.Now} 收到消息：{msg.Name}");
                await Task.CompletedTask;
            });

            Debug.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss}");
        }

        private void DoWorkPriority(object? state)
        {
            var strList = new List<string>();
            // 创建普通队列，设置好 RoutingKey
            // 和第二步 MsgProducer 项目中的普通队列名称一致！！！
            //var qNormal = bus.Advanced.QueueDeclare("StudentMessage");

            bus.Advanced.Consume<StudentMessage>(new EasyNetQ.Topology.Queue("Ers.EventBus.PriorityQueue1"), async (msg, rev) =>
            {
                strList.Add($"{nameof(DoWorkPriority)}-Priority:{msg.Properties.Priority}-{DateTimeOffset.Now} 收到消息：{msg.Body.Id},{msg.Body.Name}");
                Debug.WriteLine($"{nameof(DoWorkPriority)}-Priority:{msg.Properties.Priority}-{DateTimeOffset.Now} 收到消息：{msg.Body.Id},{msg.Body.Name}");
                await Task.CompletedTask;
            }, conf => conf.WithPrefetchCount(10));

            Debug.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss}");
        }

        private void DoWorkQos(object? state)
        {
            var strList = new List<string>();
            // 创建普通队列，设置好 RoutingKey
            // 和第二步 MsgProducer 项目中的普通队列名称一致！！！
            //var qNormal = bus.Advanced.QueueDeclare("StudentMessage");

            bus.Advanced.Consume<StudentMessage>(new EasyNetQ.Topology.Queue("Ers.EventBus.StudentConfirmQueue"), async (msg, rev, c) =>
            {
                await Task.Yield();
                strList.Add($"{nameof(DoWorkQos)}-Priority:{msg.Properties.Priority}-{DateTimeOffset.Now} 收到消息：{msg.Body.Id},{msg.Body.Name}");
                Debug.WriteLine($"{nameof(DoWorkQos)}-Priority:{msg.Properties.Priority}-{DateTimeOffset.Now} 收到消息：{msg.Body.Id},{msg.Body.Name}");
                await Task.Delay(1000);
                await Task.CompletedTask;
            }, conf => conf.WithPrefetchCount(10));


        }

        private void DoWorkConfirm(object? state)
        {
            var strList = new List<string>();
            IConnectionFactory factory = bus.Advanced.Container.Resolve<IConnectionFactory>();
            //while (true)
            //{
            using (var connection = factory.CreateConnection())
            {
                //connection.DispatchConsumersAsync = true;
                //factory.AutomaticRecoveryEnabled = true;
                //factory.DispatchConsumersAsync = true;
                using (var channel = connection.CreateModel())
                {
                    channel.BasicQos(prefetchSize: 0, prefetchCount: 2, global: false);
                    #region EventingBasicConsumer

                    //定义消费者                                      
                    var consumer = new AsyncEventingBasicConsumer(channel);
                    //接收到消息时执行的任务
                    consumer.Received += async (model, ea) =>
                    {
                        await Task.Delay(1000);
                        try
                        {
                            await Task.Yield();
                            //处理完成，手动确认
                            ((AsyncEventingBasicConsumer)model).Model.BasicAck(ea.DeliveryTag, false);
                            //channel.BasicAck(ea.DeliveryTag, false);
                        }
                        catch (Exception e)
                        {

                            throw;
                        }

                        Debug.WriteLine($"处理消息【{Encoding.UTF8.GetString(ea.Body.Span)}】完成");
                    };
                    Debug.WriteLine("消费者准备就绪....");
                    //处理消息
                    channel.BasicConsume(queue: "Ers.EventBus.StudentConfirmQueue",
                                           autoAck: false,
                                           consumer: consumer);
                    #endregion
                }
            }
            Thread.Sleep(1000);
            //}

        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("StopAsync");

            return Task.CompletedTask;
        }


        public void Dispose()
        {
            _timer?.Dispose();
        }
    }

}

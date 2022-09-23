using EasyNetQ;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Bucket.EventBus.Model;

namespace Bucket.Event.EasyQClient.BackJob
{
    public class ConsumeJobB : IHostedService, IDisposable
    {
        private IBus bus;
        private Timer _timer;
        public ConsumeJobB(IBus _bus)
        {
            bus = _bus;
        }


        public Task StartAsync(CancellationToken cancellationToken)
        {
            //_timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromSeconds(5));
            DoWork(null);

            return Task.CompletedTask;
        }

        private void DoWork(object? state)
        {
            var strList = new List<string>();
            // 创建普通队列，设置好 RoutingKey
            // 和第二步 MsgProducer 项目中的普通队列名称一致！！！
            var qNormal = bus.Advanced.QueueDeclare("Ers.EventBus.queue2");

            bus.Advanced.Consume<StudentMessage>(qNormal, (msg, msgInfo) =>
            {
                strList.Add($"{DateTimeOffset.Now} {nameof(ConsumeJobB)}收到消息：{msg.Body.Name}");
                Debug.WriteLine($"{DateTimeOffset.Now} {nameof(ConsumeJobB)}收到消息：{msg.Body.Name}");

            });

            Debug.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss}");
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

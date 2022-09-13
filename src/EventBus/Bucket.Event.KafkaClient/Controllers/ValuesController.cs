using Bucket.EventBus.Model;
using EasyNetQ;
using EasyNetQ.Topology;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Bucket.Event.KafkaClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IBus bus;
        public ValuesController(IBus _bus)
        {
            bus = _bus;
        }


        //// POST api/values
        //[HttpGet]
        ////[Route("/{orderid}")]
        //public async Task Get()
        //{
        //    for (int i = 0; i < 100; i++)
        //    {
        //        await _bus.PubSub.PublishAsync(new Order { OrderId = i });
        //    }

        //}

        [HttpGet]
        [Route("DelayProduce")]
        public (int,IEnumerable<string>) DelayProduce()
        {
            #region 安装rabbitMq延迟队列插件
            //            Download a Binary Build
            //Binary builds are distributed via GitHub releases.

            //As with all 3rd party plugins, the.ez file must be placed into a node's plugins directory and be readable by the effective user of the RabbitMQ process.

            //To find out what the plugins directory is, use rabbitmq-plugins directories

            //rabbitmq - plugins directories - s
            //Enabling the Plugin
            //Then run the following command:

            //rabbitmq - plugins enable rabbitmq_delayed_message_exchange
            #endregion
            var strList = new List<string>();

            try
            {
                for (int i = 0; i < 100; i++)
                {
                    // 建立延时 exchange
                    var exDelay = bus.Advanced.ExchangeDeclare("Ers_delay_exchange", cfg => cfg.AsDelayedExchange(ExchangeType.Direct));
                    // 建立普通 exchange
                    var exNormal = bus.Advanced.ExchangeDeclare("Ers_normal_exchange", ExchangeType.Direct);
                    // 绑定两个 exchange，设置好 RoutingKey
                    bus.Advanced.Bind(exDelay, exNormal, "delay");

                    // 创建普通队列，并和普通 exchange 绑定，设置好 RoutingKey
                    var qNormal = bus.Advanced.QueueDeclare("Ers_normal_queue");
                    bus.Advanced.Bind(exNormal, qNormal, "delay");

                    // 以下是测试发送消息的代码
                    string msg = new Random(i).Next(100, 50000).ToString();

                    // 针对单个消息，设置延迟时间（毫秒）
                    var msgHeaders = new MessageProperties();
                    msgHeaders.Headers.Add("x-delay", new Random().Next(1000, 70000));

                    // 发送消息
                    bus.Advanced.Publish(exDelay, "delay", false, new Message<string>(msg, msgHeaders));

                    Debug.WriteLine($"{DateTimeOffset.Now} 发送成功 {msg}");
                    strList.Add(msg);
                }
            }
            catch (Exception e)
            {

                throw;
            }
            finally
            {
                bus.Dispose();
            }



            return (strList.Count, strList);

        }

        [HttpGet]
        [Route("FutureProduce")]
        public (int, IEnumerable<string>) FutureProduce()
        {            
            var strList = new List<string>();

            try
            {
                for (int i = 0; i < 100; i++)
                {
                    // 以下是测试发送消息的代码
                    int sec = new Random(i).Next(100, 5000);
                    var msg = sec.ToString();
                    StudentMessage studentMessage = new StudentMessage { Id = sec, Name = $"张{msg}" };
                    bus.Scheduler.FuturePublish(studentMessage, TimeSpan.FromSeconds(sec));

                    Debug.WriteLine($"{DateTimeOffset.Now.ToUnixTimeMilliseconds()} 发送成功 {msg}");
                    strList.Add(msg);
                }
            }
            catch (Exception e)
            {

                throw;
            }
            finally
            {
                bus.Dispose();
            }



            return (strList.Count, strList);

        }
        [HttpGet]
        [Route("Publish")]
        public (int, IEnumerable<string>) Publish()
        {
            var strList = new List<string>();

            try
            {
                for (int i = 0; i < 100; i++)
                {
                    // 以下是测试发送消息的代码
                    int sec = new Random(i).Next(100, 5000);
                    var msg = sec.ToString();
                    StudentMessage studentMessage = new StudentMessage { Id = sec, Name = $"张{msg}" };
                    bus.PubSub.Publish(studentMessage);

                    Debug.WriteLine($"{DateTimeOffset.Now.ToUnixTimeMilliseconds()} 发送成功 {msg}");
                    strList.Add(msg);
                }
            }
            catch (Exception e)
            {

                throw;
            }
            finally
            {
                bus.Dispose();
            }



            return (strList.Count, strList);

        }
    }

    //[Queue("Qka.Order", ExchangeName = "Qka.Order")]
    //public class Order
    //{
    //    public int OrderId { get; set; }
    //}
    //public class OrderConsumer : IConsume<Order>
    //{
    //    [AutoSubscriberConsumer(SubscriptionId = "OrderService")]
    //    public void Consume(Order message, CancellationToken cancellationToken = default)
    //    {
    //        Debug.WriteLine($"Order:{message.OrderId},{DateTime.Now}");
    //    }
    //}
}

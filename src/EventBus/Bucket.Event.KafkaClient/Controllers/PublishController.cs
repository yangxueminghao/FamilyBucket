using Bucket.EventBus.Model;
using EasyNetQ;
using EasyNetQ.Topology;
using Microsoft.AspNetCore.Mvc;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Channels;

namespace Bucket.Event.KafkaClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishController : ControllerBase
    {
        private IBus bus;
        public PublishController(IBus _bus)
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
        public (int, IEnumerable<int>) DelayProduce()
        {
            #region 安装rabbitMq延迟队列插件
            //            Download a Binary Build
            //Binary builds are distributed via GitHub releases.

            //As with all 3rd party plugins, the.ez file must be placed into a node's plugins directory and be readable by the effective user of the RabbitMQ process.

            //To find out what the plugins directory is, use rabbitmq-plugins directories
            //rabbitmq-plugins list
            //rabbitmq-plugins directories -s
            //Enabling the Plugin
            //Then run the following command:
            //rabbitmq-plugins enable rabbitmq_delayed_message_exchange
            #endregion
            var strList = new List<int>();

            try
            {
                for (int i = 0; i < 100; i++)
                {
                    // 建立延时 exchange
                    var exDelay = bus.Advanced.ExchangeDeclare("Ers_delay_exchange", cfg => cfg.AsDelayedExchange(EasyNetQ.Topology.ExchangeType.Direct));
                    // 建立普通 exchange
                    var exNormal = bus.Advanced.ExchangeDeclare("Ers_normal_exchange", EasyNetQ.Topology.ExchangeType.Direct);
                    // 绑定两个 exchange，设置好 RoutingKey
                    bus.Advanced.Bind(exDelay, exNormal, "delay");

                    // 创建普通队列，并和普通 exchange 绑定，设置好 RoutingKey
                    var qNormal = bus.Advanced.QueueDeclare("Ers_normal_queue");
                    bus.Advanced.Bind(exNormal, qNormal, "delay");

                    // 以下是测试发送消息的代码
                    int expire = new Random(i).Next(1000, 700000);

                    // 针对单个消息，设置延迟时间（毫秒）
                    var msgHeaders = new MessageProperties();
                    msgHeaders.Headers.Add("x-delay", expire);

                    // 发送消息
                    bus.Advanced.Publish(exDelay, "delay", false, new Message<int>(expire, msgHeaders));

                    Debug.WriteLine($"{DateTimeOffset.Now} 发送成功 {expire}");
                    strList.Add(expire);
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
        [HttpGet]
        [Route("PublishTopic")]
        public (int, IEnumerable<string>) PublishTopic()
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



            return (strList.Count, strList);

        }

        [HttpGet]
        [Route("PublishPriority")]
        public (int, IEnumerable<string>) PublishPriority()
        {
            var strList = new List<string>();

            try
            {
                var exchange1 = bus.Advanced.ExchangeDeclare("Ers.EventBus.StudentPriorityEx", "topic");

                var queuePriority = bus.Advanced.QueueDeclare("Ers.EventBus.PriorityQueue1", conf => conf.WithMaxPriority(9));//优先级队列才支持优先级消息
                bus.Advanced.Bind(exchange1, queuePriority, "Ers.*.Student");
                for (int i = 0; i < 500; i++)
                {
                    // 以下是测试发送消息的代码
                    int sec = new Random(i).Next(100, 5000);
                    var msg = sec.ToString();
                    StudentMessage studentMessage = new StudentMessage { Id = i, Name = $"张{msg}" };
                    try
                    {
                        var properties = new MessageProperties { Priority = (byte)(i % 10) };
                        bus.Advanced.Publish<StudentMessage>(exchange1, "Ers.b.Student", false, new Message<StudentMessage>(studentMessage, properties));
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"{ex.Message}");
                    }


                    Debug.WriteLine($"{nameof(PublishPriority)}{DateTimeOffset.Now.ToUnixTimeMilliseconds()} 发送成功{i}- {msg}");
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



            return (strList.Count, strList);

        }

        [HttpGet]
        [Route("PublishLimit")]
        public (int, IEnumerable<string>) PublishLimit()
        {
            var strList = new List<string>();

            try
            {
                var exchange = bus.Advanced.ExchangeDeclare("Ers.EventBus.StudentLimitEx", "topic");
                var exchangeDead = bus.Advanced.ExchangeDeclare("Ers.EventBus.StudentLimitDeadEx", "topic");
                var queueDead = bus.Advanced.QueueDeclare("Ers.EventBus.StudentLimitDeadQueue", conf => conf
                .WithMaxPriority(9)
                );
                bus.Advanced.Bind(exchangeDead, queueDead, "Ers.Dead.*.Student");

                var queueLimit = bus.Advanced.QueueDeclare("Ers.EventBus.StudentLimitQueue", conf => conf
                .WithMaxLength(10)
                .WithOverflowType(OverflowType.RejectPublishDlx)
                .WithDeadLetterExchange(exchangeDead)
                .WithDeadLetterRoutingKey("Ers.Dead.a.Student")
                );//优先级队列才支持优先级消息
                bus.Advanced.Bind(exchange, queueLimit, "Ers.*.Student");
                for (int i = 0; i < 500; i++)
                {
                    // 以下是测试发送消息的代码
                    int sec = new Random(i).Next(100, 5000);
                    var msg = sec.ToString();
                    StudentMessage studentMessage = new StudentMessage { Id = i, Name = $"张{msg}" };
                    try
                    {
                        var properties = new MessageProperties { Priority = (byte)(i % 10) };
                        bus.Advanced.Publish<StudentMessage>(exchange, "Ers.b.Student", false, new Message<StudentMessage>(studentMessage, properties));
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"{ex.Message}");
                    }


                    Debug.WriteLine($"{nameof(PublishLimit)}{DateTimeOffset.Now.ToUnixTimeMilliseconds()} 发送成功{i}- {msg}");
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



            return (strList.Count, strList);

        }

        [HttpGet]
        [Route("PublishQos")]
        public (int, IEnumerable<string>) PublishQos()
        {
            var strList = new List<string>();

            try
            {
                var exchange = bus.Advanced.ExchangeDeclare("Ers.EventBus.StudentConfirmEx", "topic");

                var queue = bus.Advanced.QueueDeclare("Ers.EventBus.StudentConfirmQueue");//优先级队列才支持优先级消息
                bus.Advanced.Bind(exchange, queue, "Ers.*.Student");
                for (int i = 0; i < 500; i++)
                {
                    // 以下是测试发送消息的代码
                    int sec = new Random(i).Next(100, 5000);
                    var msg = sec.ToString();
                    StudentMessage studentMessage = new StudentMessage { Id = i, Name = $"张{msg}" };
                    try
                    {
                        var properties = new MessageProperties { Priority = (byte)(i % 10), DeliveryMode = 2 };
                        bus.Advanced.Publish<StudentMessage>(exchange, "Ers.b.Student", false, new Message<StudentMessage>(studentMessage, properties));
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"{ex.Message}");
                    }


                    Debug.WriteLine($"{nameof(PublishQos)}{DateTimeOffset.Now.ToUnixTimeMilliseconds()} 发送成功{i}- {msg}");
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



            return (strList.Count, strList);

        }
        [HttpGet]
        [Route("PublishConfirm")]
        public (int, IEnumerable<string>) PublishConfirm()
        {
            var strList = new List<string>();

            try
            {
                IConnectionFactory factory = bus.Advanced.Container.Resolve<IConnectionFactory>();
                //AutomaticRecoveryEnabled = true; DispatchConsumersAsync = true;
                int i = 0;
                int ackNum = 0;
                int nackNum = 0;
                while (i < 100)
                {
                    //注册发布者监听器
                    using (var connection = factory.CreateConnection())
                    {
                        using (var channel = connection.CreateModel())
                        {
                            var baPro = channel.CreateBasicProperties();
                            baPro.DeliveryMode = 2;
                            baPro.Persistent = true;
                            channel.ConfirmSelect();
                            
                            channel.BasicAcks += (model, arg) =>
                            {
                                ackNum++;
                                //(model as IModel)
                            };
                            channel.BasicNacks += (model, arg) =>
                            {
                                nackNum++;
                            };
                            channel.BasicPublish("Ers.EventBus.StudentConfirmEx", "Ers.b.Student", false, baPro, Encoding.UTF8.GetBytes("zhang" + i));
                            channel.WaitForConfirms();
                            i++;
                        }
                    }

                    Thread.Sleep(1000);
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



            return (strList.Count, strList);

        }

        [HttpGet]
        [Route("PublishConfirm2")]
        public (int, IEnumerable<string>) PublishConfirm2()
        {
            var strList = new List<string>();
            var confirmCount = 0;
            var nonConfirmedCount = 0;

            //using (var channel = bus.OpenPublishChannel(x => x.WithPublisherConfirms()))
            //{
            //    for (int i = 0; i < 100; i++)
            //    {
            //        var message = new StudentMessage { Id = i, Name = $"张{i}" };
            //        channel.Publish(message, x =>
            //                x.OnSuccess(() =>
            //                {
            //                    callbackCount++;
            //                    confirmCount++;
            //                })
            //                .OnFailure(() =>
            //                {
            //                    callbackCount++;
            //                    nonConfirmedCount++;
            //                }));
            //    }

            //}  
            Debug.WriteLine("The confirmed count is: {0}.", confirmCount);
            Debug.WriteLine("The non confirmed count is: {0}", nonConfirmedCount);


            return (strList.Count, strList);

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
}

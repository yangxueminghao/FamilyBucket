using EasyNetQ;
using EasyNetQ.AutoSubscribe;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Bucket.Event.EasyNetQClient.Controllers
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

        // POST api/values
        [HttpGet]
        [Route("Consume")]
        public (int, IEnumerable<string>) Consume()
        {
            var strList = new List<string>();
            // 创建普通队列，设置好 RoutingKey
            // 和第二步 MsgProducer 项目中的普通队列名称一致！！！
            var qNormal = bus.Advanced.QueueDeclare("Ers_normal_queue");
            int i = 1;
            while (i < 5)
            {
                bus.Advanced.Consume<string>(qNormal, (msg, msgInfo) =>
                {
                    strList.Add($"{DateTimeOffset.Now.ToUnixTimeMilliseconds()} 收到消息：{msg.Body}");
                    Debug.WriteLine($"{DateTimeOffset.Now.ToUnixTimeMilliseconds()} 收到消息：{msg.Body}");
                    i++;

                });
                //i++;
            }
            // MsgHandle 也可以用匿名方法
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

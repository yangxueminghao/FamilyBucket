using Bucket.EventBus.Model;
using EasyNetQ;
using EasyNetQ.Topology;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Bucket.Event.KafkaClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsumeController : ControllerBase
    {
        private IBus bus;
        public ConsumeController(IBus _bus)
        {
            bus = _bus;
        }



        [HttpGet]
        [Route("BasicGet")]
        public async Task<(int, IEnumerable<int>)> BasicGet()
        {
            var strList = new List<int>();

            try
            {
                var queue = new EasyNetQ.Topology.Queue("Ers.EventBus.StudentLimitDeadQueue");
                var pulls = bus.Advanced.CreatePullingConsumer<StudentMessage>(queue);
                for (int i = 0; i < 100; i++)
                {
                    var msg = await pulls.PullAsync();
                    Debug.WriteLine($"{DateTimeOffset.Now} 消费成功 {i}:{msg.Message.Body}");
                    strList.Add(msg.Message.Body.Id);
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

}

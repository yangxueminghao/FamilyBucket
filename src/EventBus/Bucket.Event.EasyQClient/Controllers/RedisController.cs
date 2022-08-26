using EasyNetQ;
using EasyNetQ.AutoSubscribe;
using InitQ.Cache;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
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
    public class RedisController : ControllerBase
    {
        private IServiceProvider _provider;
        public RedisController(IServiceProvider provider)
        {
            _provider = provider;
        }

        [HttpGet]
        [Route("Run")]
        public ActionResult Run()
        {
            SubscribeRun().Wait();
            return Ok();

        }
        [NonAction]
        public async Task SubscribeRun()
        {
          await  Task.Run(async () =>
            {

                using (var scope = _provider.GetRequiredService<IServiceScopeFactory>().CreateScope())
                {
                    //redis对象
                    var _redis = scope.ServiceProvider.GetService<ICacheService>();

                    for (int i = 0; i < 2; i++)
                    {
                        var dt = DateTime.Now.AddMinutes(3 * (i + 1));
                        //key:redis里的key,唯一
                        //msg:任务
                        //time:延时执行的时间
                        await _redis.SortedSetAddAsync("Delay_RedisMQ", $"延迟任务,第{i + 1}个元素,执行时间:{dt.ToString("yyyy-MM-dd HH:mm:ss")}", dt);
                    }
                }
            });

        }
    }

}

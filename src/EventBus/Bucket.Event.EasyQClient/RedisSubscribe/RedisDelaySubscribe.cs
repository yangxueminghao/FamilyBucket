using InitQ.Abstractions;
using InitQ.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bucket.Event.EasyQClient.RedisSubscribe
{
    public class RedisDelaySubscribe: IRedisSubscribe
    {
        //延迟队列
        [SubscribeDelay("Delay_RedisMQ")]
        private async Task SubscribeDelayRedisMQ(string msg)
        {
            Console.WriteLine($"A类--->当前时间:{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} 订阅者延迟队列消息开始--->{msg}");
            //模拟任务执行耗时
            var m = new Random().Next(1, 10);
            await Task.Delay(TimeSpan.FromSeconds(m));
            Console.WriteLine($"A类--->{msg} 结束<---");
        }
    }
}

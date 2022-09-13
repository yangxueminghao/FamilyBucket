using EasyNetQ.AutoSubscribe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bucket.Event.KafkaClient.Model
{
    [EasyNetQ.Queue("StudentMessage",ExchangeName = "Bucket.Event.KafkaClient.Model.StudentMessage, Bucket.Event.KafkaClient")]
    public class StudentMessage
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

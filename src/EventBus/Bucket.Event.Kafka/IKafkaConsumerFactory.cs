using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucket.Event.Kafka
{
    public interface IKafkaConsumerFactory<TConsumer>
       where TConsumer : AbstractConsumer
    {
        TConsumer Create();
    }
}

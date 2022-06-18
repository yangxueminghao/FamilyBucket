using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucket.Event.Kafka
{
    public interface IKafkaProducerFactory<TProducer>
       where TProducer : AbstractProducer
    {
        TProducer Create();
    }
}

using Confluent.Kafka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucket.Event.Kafka
{
    public class StandProducer<TKey, TValue> : AbstractProducer<TKey, TValue>
    {
        public StandProducer(ProducerConfig proConfig) : base(new ProducerBuilder<TKey, TValue>(proConfig))
        {

        }

        public override void AbortTransaction()
        {
            InnerProducer.AbortTransaction();
        }

        public override void CommitTransaction()
        {
            InnerProducer.CommitTransaction();
        }
    }
}

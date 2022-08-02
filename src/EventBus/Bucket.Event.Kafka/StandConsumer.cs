using Confluent.Kafka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucket.Event.Kafka
{
    public class StandConsumer<TKey, TValue> : AbstractConsumer<TKey, TValue>
    {
        public StandConsumer(ProducerConfig proConfig)
        {

        }

        public override void IncrementalAssign(IEnumerable<TopicPartitionOffset> partitions)
        {
            throw new NotImplementedException();
        }

        public override void IncrementalAssign(IEnumerable<TopicPartition> partitions)
        {
            throw new NotImplementedException();
        }

        public override void IncrementalUnassign(IEnumerable<TopicPartition> partitions)
        {
            throw new NotImplementedException();
        }
    }
}

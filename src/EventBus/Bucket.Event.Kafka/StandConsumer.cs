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
        public StandConsumer(ConsumerConfig conConfig) : base(new ConsumerBuilder<TKey, TValue>(conConfig))
        {

        }

        public override void IncrementalAssign(IEnumerable<TopicPartitionOffset> partitions)
        {
            consumer.IncrementalAssign(partitions);
        }

        public override void IncrementalAssign(IEnumerable<TopicPartition> partitions)
        {
            consumer.IncrementalAssign(partitions);
        }

        public override void IncrementalUnassign(IEnumerable<TopicPartition> partitions)
        {
            consumer.IncrementalAssign(partitions);
        }
    }
}

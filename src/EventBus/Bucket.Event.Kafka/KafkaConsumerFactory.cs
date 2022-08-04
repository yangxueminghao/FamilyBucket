using Confluent.Kafka;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucket.Event.Kafka
{
    public class KafkaConsumerFactory<TConsumer> : IKafkaConsumerFactory<TConsumer>
       where TConsumer : AbstractConsumer
    {
        private readonly IOptionsSnapshot<ConsumerConfig> options;

        public KafkaConsumerFactory(IOptionsSnapshot<ConsumerConfig> options)
            => this.options = options;

        public TConsumer Create()
        {
            //var producerConfig = this.options.Get(typeof(TProducer).Name);
            var consumerConfig = this.options.Value;

            var consumer = (TConsumer)Activator.CreateInstance(typeof(TConsumer), consumerConfig);

            return consumer;
        }
    }
}

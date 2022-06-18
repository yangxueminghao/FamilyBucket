using Confluent.Kafka;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucket.Event.Kafka
{
    public class KafkaProducerFactory<TProducer> : IKafkaProducerFactory<TProducer>
       where TProducer : AbstractProducer
    {
        private readonly IOptionsMonitor<ProducerConfig> options;

        public KafkaProducerFactory(IOptionsMonitor<ProducerConfig> options)
            => this.options = options;

        public TProducer Create()
        {
            var producerConfig = this.options.Get(typeof(TProducer).Name);

            var producer = (TProducer)Activator.CreateInstance(typeof(TProducer), producerConfig);

            return producer;
        }
    }
}

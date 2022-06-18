using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Bucket.Event.Kafka
{
    public class KafkaProducerManager
    {
        private readonly IServiceProvider services;
        private readonly ConcurrentDictionary<Type, object> factories;

        public KafkaProducerManager(IServiceProvider services)
        {
            this.services = services;
        }

        public virtual TProducer Create<TProducer>()
            where TProducer : AbstractProducer
        {
            var factory = services.GetRequiredService<IKafkaProducerFactory<TProducer>>();

            return factory.Create();
        }
    }
}

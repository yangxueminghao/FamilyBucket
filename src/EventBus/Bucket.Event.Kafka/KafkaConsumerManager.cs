using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Bucket.Event.Kafka
{
    public class KafkaConsumerManager
    {
        private readonly IServiceProvider services;
        private readonly ConcurrentDictionary<Type, object> factories;

        public KafkaConsumerManager(IServiceProvider services)
        {
            this.services = services;
        }

        public virtual TConsumer Create<TConsumer>()
            where TConsumer : AbstractConsumer
        {
            var factory = services.GetRequiredService<IKafkaConsumerFactory<TConsumer>>();

            return factory.Create();
        }
    }
}

﻿using Confluent.Kafka;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Bucket.Event.Kafka
{
    public class AbstractProducer
    {
    }

    public abstract class AbstractProducer<TKey, TValue> : AbstractProducer, IProducer<TKey, TValue>
    {
        protected AbstractProducer(ProducerBuilder<TKey, TValue> builder)
        {
            InnerProducer = builder.Build();
        }

        protected readonly IProducer<TKey, TValue> InnerProducer;

        public Handle Handle => InnerProducer.Handle;
        public string Name => InnerProducer.Name;

        public int AddBrokers(string brokers)
        {
            return this.InnerProducer.AddBrokers(brokers);
        }

        public int Flush(TimeSpan timeout)
        {
            return this.InnerProducer.Flush(timeout);
        }

        public void Flush(CancellationToken cancellationToken = default)
        {
            this.InnerProducer.Flush(cancellationToken);
        }

        public int Poll(TimeSpan timeout)
        {
            return this.InnerProducer.Poll(timeout);
        }

        public void Produce(string topic, Message<TKey, TValue> message, Action<DeliveryReport<TKey, TValue>>? deliveryHandler = null)
        {
            this.InnerProducer.Produce(topic, message, deliveryHandler);
        }

        public void Produce(TopicPartition topicPartition, Message<TKey, TValue> message, Action<DeliveryReport<TKey, TValue>>? deliveryHandler = null)
        {
            this.InnerProducer.Produce(topicPartition, message, deliveryHandler);
        }

        public Task<DeliveryResult<TKey, TValue>> ProduceAsync(string topic, Message<TKey, TValue> message)
        {
            return this.InnerProducer.ProduceAsync(topic, message);
        }

        public Task<DeliveryResult<TKey, TValue>> ProduceAsync(TopicPartition topicPartition, Message<TKey, TValue> message)
        {
            return this.InnerProducer.ProduceAsync(topicPartition, message);
        }

        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                    this.InnerProducer?.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~AbstractProducer()
        // {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public Task<DeliveryResult<TKey, TValue>> ProduceAsync(string topic, Message<TKey, TValue> message, CancellationToken cancellationToken = default)
        {
            return InnerProducer.ProduceAsync(topic, message, cancellationToken);
        }

        public Task<DeliveryResult<TKey, TValue>> ProduceAsync(TopicPartition topicPartition, Message<TKey, TValue> message, CancellationToken cancellationToken = default)
        {
            return InnerProducer.ProduceAsync(topicPartition, message, cancellationToken);
        }

        public void InitTransactions(TimeSpan timeout)
        {
            InnerProducer.InitTransactions(timeout);
        }

        public void BeginTransaction()
        {
            InnerProducer.BeginTransaction();
        }

        public void CommitTransaction(TimeSpan timeout)
        {
            InnerProducer.CommitTransaction(timeout);
        }

        public void AbortTransaction(TimeSpan timeout)
        {
            InnerProducer.AbortTransaction(timeout);
        }

        public void SendOffsetsToTransaction(IEnumerable<TopicPartitionOffset> offsets, IConsumerGroupMetadata groupMetadata, TimeSpan timeout)
        {
            InnerProducer.SendOffsetsToTransaction(offsets, groupMetadata, timeout);
        }

      
        public abstract void CommitTransaction();
        public abstract void AbortTransaction();
    }
}

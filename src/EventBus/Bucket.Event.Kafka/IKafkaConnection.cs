using System;

namespace Bucket.EventBus.RabbitMQ
{
    public interface IKafkaConnection
         : IDisposable
    {
        bool IsConnected { get; }

        bool TryConnect();

    }
}

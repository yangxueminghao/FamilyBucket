using DotNetCore.CAP;
using System;
using System.Diagnostics;

namespace Bucket.EventBus.Cap.Services
{
    public class SubscriberService : ISubscriberService, ICapSubscribe
    {
        [CapSubscribe("fyu.services.show.time")]
        public void CheckReceivedMessage(DateTime datetime)
        {
            Debug.WriteLine(datetime);
        }
    }
}

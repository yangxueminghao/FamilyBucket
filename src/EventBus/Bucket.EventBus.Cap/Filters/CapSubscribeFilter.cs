using DotNetCore.CAP.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bucket.EventBus.Cap.Filters
{
    public class CapSubscribeFilter : SubscribeFilter
    {
        public override void OnSubscribeException(ExceptionContext context)
        {
            context.ExceptionHandled = true; 
        }
        public override void OnSubscribeExecuted(ExecutedContext context)
        {
            
            base.OnSubscribeExecuted(context);
        }
        public override void OnSubscribeExecuting(ExecutingContext context)
        {            
            base.OnSubscribeExecuting(context); 
        }
    }
}

using Bucket.Event.Kafka;
using Confluent.Kafka;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Bucket.EventBus.Cap.Controllers
{
    [ApiController]
    [Route("[Controller]/[Action]")]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ProducerConfig _ProducerConfig;
        private readonly IKafkaProducerFactory<StandProducer<string,string>> _kafkaProducerFactory;
        
        public HomeController(ILogger<HomeController> logger,
            IOptions<ProducerConfig> producerConfig,
            IKafkaProducerFactory<StandProducer<string, string>> kafkaProducerFactory) 
        {
            _logger = logger;
            _ProducerConfig = producerConfig.Value;
            _kafkaProducerFactory = kafkaProducerFactory;
        }
        [HttpGet]
        public async Task<IEnumerable<string>> GetValues()
        {
            using (var producer =_kafkaProducerFactory.Create())
            {
                for (int i = 0; i < 100; i++)
                {
                    string text;
                    try
                    {
                        //text = Console.ReadLine();
                        text = "yzh " + new Random().Next().ToString();
                    }
                    catch (IOException)
                    {
                        // IO exception is thrown when ConsoleCancelEventArgs.Cancel == true.
                        break;
                    }
                    if (text == null)
                    {
                        // Console returned null before 
                        // the CancelKeyPress was treated
                        break;
                    }

                    string key = null;
                    string val = text;

                    // split line if both key and value specified.
                    int index = text.IndexOf(" ");
                    if (index != -1)
                    {
                        key = text.Substring(0, index);
                        val = text.Substring(index + 1);
                    }

                    try
                    {
                        // Note: Awaiting the asynchronous produce request below prevents flow of execution
                        // from proceeding until the acknowledgement from the broker is received (at the 
                        // expense of low throughput).
                        var deliveryReport = await producer.ProduceAsync(
                            "test_topic", new Message<string, string> { Key = key, Value = val });

                        Console.WriteLine($"delivered to: {deliveryReport.TopicPartitionOffset}");
                    }
                    catch (ProduceException<string, string> e)
                    {
                        Console.WriteLine($"failed to deliver message: {e.Message} [{e.Error.Code}]");
                    }
                }
                
            }
            
            _logger.LogInformation("{q}请求开始", "a");
            return  new string[]{ "a","b"};
            //_logger.LogInformation("{q}请求结束", "b");
        }
    }
}

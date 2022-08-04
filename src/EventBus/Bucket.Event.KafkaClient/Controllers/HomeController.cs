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
        private readonly IOptionsSnapshot<ConsumerConfig> _consumerConfig;
        private readonly KafkaConsumerManager _kafkaConsumerManager;
        

        public HomeController(ILogger<HomeController> logger,
            IOptions<ProducerConfig> producerConfig,
            IKafkaProducerFactory<StandProducer<string, string>> kafkaProducerFactory,
            IOptionsSnapshot<ConsumerConfig> consumerConfig,
            KafkaConsumerManager kafkaConsumerManager) 
        {
            _logger = logger;
            _ProducerConfig = producerConfig.Value;
            _kafkaProducerFactory = kafkaProducerFactory;
            _consumerConfig = consumerConfig;
            _kafkaConsumerManager = kafkaConsumerManager;
        }
        [HttpGet]
        public async Task<IEnumerable<string>> Product()
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

        [HttpGet]
        public  IEnumerable<string> Consume()
        {
            using (var consumer = _kafkaConsumerManager.Create<StandConsumer<string,string>>())
            {
                consumer.Subscribe("test_topic");

                try
                {
                    while (true)
                    {
                        try
                        {
                            const int commitPeriod = 5;
                            var consumeResult = consumer.Consume();

                            if (consumeResult.IsPartitionEOF)
                            {
                                Console.WriteLine(
                                    $"Reached end of topic {consumeResult.Topic}, partition {consumeResult.Partition}, offset {consumeResult.Offset}.");

                                continue;
                            }

                            Console.WriteLine($"Received message at {consumeResult.TopicPartitionOffset}: {consumeResult.Message.Value}");

                            if (consumeResult.Offset % commitPeriod == 0)
                            {
                                // The Commit method sends a "commit offsets" request to the Kafka
                                // cluster and synchronously waits for the response. This is very
                                // slow compared to the rate at which the consumer is capable of
                                // consuming messages. A high performance application will typically
                                // commit offsets relatively infrequently and be designed handle
                                // duplicate messages in the event of failure.
                                try
                                {
                                    consumer.Commit(consumeResult);
                                }
                                catch (KafkaException e)
                                {
                                    Console.WriteLine($"Commit error: {e.Error.Reason}");
                                }
                            }
                        }
                        catch (ConsumeException e)
                        {
                            Console.WriteLine($"Consume error: {e.Error.Reason}");
                        }
                    }
                }
                catch (OperationCanceledException)
                {
                    Console.WriteLine("Closing consumer.");
                    consumer.Close();
                }

            }

            _logger.LogInformation("{q}请求开始", "a");
            return new string[] { "a", "b" };
            //_logger.LogInformation("{q}请求结束", "b");
        }
    }
}

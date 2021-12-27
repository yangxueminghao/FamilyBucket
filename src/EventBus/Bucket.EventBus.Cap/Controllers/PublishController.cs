using Bucket.EventBus.Cap.Models;
using DotNetCore.CAP;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using Bucket.MongoDbContext.Mongo;

namespace Bucket.EventBus.Cap.Controllers
{
    [ApiController]
    [Route("[Controller]/[Action]")]
    public class PublishController : ControllerBase
    {
        private readonly ILogger<PublishController> _logger;
        private readonly IConfiguration _Configuration;
        private readonly ICapPublisher _capBus;
        private readonly IMongoDbRepository<Student> _mongo;
        public PublishController(ILogger<PublishController> logger, 
            IConfiguration Configuration,
            ICapPublisher capBus,
            IMongoDbRepository<Student> mongo) 
        {
            _logger = logger;
            _Configuration = Configuration;
            _capBus = capBus;
            _mongo = mongo;
        }
        [HttpGet]
        [Route("~/adonet/transaction")]
        public IActionResult AdonetWithTransaction()
        {
            using (var connection = new MySqlConnection(_Configuration["Cap:Db:Con"].ToString()))
            {
                using (var transaction = connection.BeginTransaction(_capBus, autoCommit: true))
                {
                    //docker run -d--hostname my-rabbit--name rabbit -e RABBITMQ_DEFAULT_USER = sa - e RABBITMQ_DEFAULT_PASS = 123456 - p 15672:15672 - p 5672:5672 - p 25672:25672 - p 61613:61613 - p 1883:1883 rabbitmq: management
                                var now = DateTime.Now;
                    _logger.LogInformation("发布当前时间{datetime}", now);
                    _capBus.Publish("Bucket.EventBus.Cap.show.time", now);
                }
            }

            return Ok();
        }
        [HttpPost]
        public IActionResult CreateStudent(Student stu)
        {
            using (var connection = new MySqlConnection(_Configuration["Cap:Db:Con"].ToString()))
            {
                using (var transaction = connection.BeginTransaction(_capBus, autoCommit: true))
                {
                    //docker run -d--hostname my-rabbit--name rabbit -e RABBITMQ_DEFAULT_USER = sa - e RABBITMQ_DEFAULT_PASS = 123456 - p 15672:15672 - p 5672:5672 - p 25672:25672 - p 61613:61613 - p 1883:1883 rabbitmq: management
                    
                    _logger.LogInformation("CreateStudent({student})", JsonSerializer.Serialize(stu));
                    _capBus.Publish("Bucket.EventBus.Cap.CreateStudent", JsonSerializer.Serialize(stu));
                }
            }

            return Ok();
        }
        [HttpGet,HttpPost]
        [CapSubscribe("Bucket.EventBus.Cap.show.time")]
        public string CheckReceivedMessage(DateTime datetime)
        {
            _logger.LogInformation("订阅到当前时间{datetime}",datetime);
            return datetime.ToString("yyyy-MM-dd HH:mm:ss");
        }
        [NonAction]
        [CapSubscribe("Bucket.EventBus.Cap.CreateStudent")]
        public Student CreateStudentHander(string  s)
        {
            Student stu = JsonSerializer.Deserialize<Student>(s);
            _logger.LogInformation("CreateStudentHander({student})", JsonSerializer.Serialize(stu));
            _mongo.InsertOne(stu);
            return stu;
        }
    }
}

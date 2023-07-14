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
using Bucket.DapperContext.Dapper;
using MySqlX.XDevAPI.Relational;

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
        private readonly IDapperDbRepository<Student> _dapper;
        public PublishController(ILogger<PublishController> logger,
            IConfiguration Configuration,
            ICapPublisher capBus//,
            //IMongoDbRepository<Student> mongo,
            //IDapperDbRepository<Student> dapper
            )
        {
            _logger = logger;
            _Configuration = Configuration;
            _capBus = capBus;
            //_mongo = mongo;
            //_dapper = dapper;
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
        public int PublishDelay()
        {
            _capBus.PublishDelay<DateTime>(TimeSpan.FromMinutes(1),"Bucket.EventBus.Cap.show.time.delay", DateTime.Now, callbackName: "Bucket.EventBus.Cap.show.time.delay.callback");
            var now = DateTime.Now;
            //_capBus.Publish("Bucket.EventBus.Cap.show.time", now);
            return 1;
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
                    _capBus.Publish<Student>("Bucket.EventBus.Cap.CreateStudent", stu, callbackName: "Bucket.EventBus.Cap.CreateStudentCallback");
                }
            }

            return Ok();
        }
        [HttpGet, HttpPost]
        [CapSubscribe("Bucket.EventBus.Cap.show.time")]
        public string CheckReceivedMessage(DateTime datetime)
        {
            _logger.LogInformation("订阅到当前时间{datetime}", datetime);
            return datetime.ToString("yyyy-MM-dd HH:mm:ss");
        }
        [NonAction]
        [CapSubscribe("Bucket.EventBus.Cap.CreateStudent", Group = "Mongo")]
        public Student CreateStudentMongoHander(Student stu)
        {
            _logger.LogInformation("CreateStudentMongoHander({student})", JsonSerializer.Serialize(stu));
            _mongo.InsertOne(stu);
            return stu;
        }
        [NonAction]
        [CapSubscribe("Bucket.EventBus.Cap.CreateStudent", Group = "Dapper")]
        public Student CreateStudentDapperHander(Student stu)
        {
            _logger.LogInformation("CreateStudentDapperHander({student})", JsonSerializer.Serialize(stu));
            _dapper.Insert(stu);
            return stu;
        }
        [NonAction]
        [CapSubscribe("Bucket.EventBus.Cap.CreateStudentCallback")]
        public Student CreateStudentCallback(Student stu)
        {
            _logger.LogInformation("CreateStudentCallback({student})", JsonSerializer.Serialize(stu));
            stu.Name += "callback";
            _dapper.Insert(stu);
            return stu;
        }
        [NonAction]
        [CapSubscribe("Bucket.EventBus.Cap.show.time.delay", Group = "Mysql")]
        public DateTime CheckReceivedDelayMessage(DateTime datetime)
        {
            _logger.LogInformation("CheckReceivedDelayMessage订阅到当前时间{datetime}", datetime);
            return datetime;
        }
        //消费者处理方法的出参成为回调函数的入参
        [HttpGet, HttpPost]
        [CapSubscribe("Bucket.EventBus.Cap.show.time.delay.callback", Group = "Mysqlcallback")]
        public string CheckReceivedDelayMessageCallback(DateTime datetime)
        {
            _logger.LogInformation("CheckReceivedDelayMessageCallback订阅到当前时间{datetime}", datetime);
            return datetime.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}

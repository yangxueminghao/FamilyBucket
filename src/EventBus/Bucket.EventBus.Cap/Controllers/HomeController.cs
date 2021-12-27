using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bucket.EventBus.Cap.Controllers
{
    [ApiController]
    [Route("[Controller]/[Action]")]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger) 
        {
            _logger = logger;
        }
        [HttpGet]
        public IEnumerable<string> GetValues()
        {
            _logger.LogInformation("{q}请求开始", "a");
            return  new string[]{ "a","b"};
            //_logger.LogInformation("{q}请求结束", "b");
        }
    }
}

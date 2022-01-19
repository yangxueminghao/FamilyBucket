using Bucket.DapperContext.Dapper;
using FamilyBucket.Aop.Client.Model;
using FamilyBucket.Aop.Client.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyBucket.Aop.Client.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly DapperOption _dapperOption;
        private readonly IStudentService _service; 
        public HomeController(IOptionsMonitor<DapperOption> optionsMonitor, IStudentService service)
        {
            _dapperOption = optionsMonitor.CurrentValue;
            _service = service;
        }
        [HttpGet]
        public Student Get()
        {
            //return _dapperOption.ConStrs;
            return _service.Get(1);
        }

    }
}

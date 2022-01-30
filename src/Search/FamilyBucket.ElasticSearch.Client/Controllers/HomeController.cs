using FamilyBucket.ElasticSearch.Client.Model;
using Microsoft.AspNetCore.Mvc;
using Nest;
using System;

namespace FamilyBucket.ElasticSearch.Client.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IElasticClient _elasticClient;
        public HomeController(IElasticClient elasticClient)
        {
            _elasticClient = elasticClient;
        }
        [HttpGet]
        public Student Get()
        {
            var student = new Student
            {
                Id = 3,
                Name = "zhangsi",
                Birthday = DateTime.Now
            };
            var response = _elasticClient.Index(student, idx => idx.Index("students"));
            var result = _elasticClient.Get<Student>(3, idx => idx.Index("students"));
            return result.Source;
        }

    }
}

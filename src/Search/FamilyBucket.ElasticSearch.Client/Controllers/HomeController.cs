using FamilyBucket.ElasticSearch.Client.Model;
using Microsoft.AspNetCore.Mvc;
using Nest;
using System;
using System.Collections.Generic;

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
                //Birthday = DateTime.Now
            };
            var response = _elasticClient.Index(student, idx => idx.Index("students"));
            var result = _elasticClient.Get<Student>(3, idx => idx.Index("students"));
            return result.Source;
        }
        [HttpGet]
        public IEnumerable<Student> Search(string name)
        {
           
            var response = _elasticClient.Search<Student>(s=> 
                s.Index("students")
                .From(0)
                .Size(10)
                .Query(q => q.Term(t => t.Name, "zhangsi") ||
                q.Match(m => m.Field(f => f.Id).Query("3"))
                )
            );
            var result = response.Documents;
            return result;
        }

    }
}

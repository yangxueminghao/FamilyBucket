﻿using Bucket.DapperContext.Dapper;
using FamilyBucket.ElasticSearch.Client.Model;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.IO;

namespace FamilyBucket.ElasticSearch.Client.Job
{
    public class MedicationJob : BackgroundService
    {
        private readonly ILogger<MedicationJob> _logger;
        private IDapperDbRepository<Student> _repository;
        private IElasticClient _elasticClient;
        private readonly IServiceProvider _provider;
        private Timer _timer;

        public MedicationJob(ILogger<MedicationJob> logger,
            IServiceProvider provider)
        {
            _logger = logger;
            _provider = provider;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _timer = new Timer(MedicationSync, null, TimeSpan.Zero, TimeSpan.FromSeconds(10));
            return Task.CompletedTask;
        }
        private void MedicationSync(object state)
        {
            using (var scope = _provider.CreateScope())
            {
                _repository = scope.ServiceProvider.GetService<IDapperDbRepository<Student>>();
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "medication.txt");
                if (!File.Exists(filePath))
                {
                    File.Create(filePath);
                }
                Dictionary<string, object> para = new Dictionary<string, object>();
                string recordTime = File.ReadAllText(filePath);
                var lastUpdateTime = string.IsNullOrWhiteSpace(recordTime) ? DateTime.MinValue : DateTime.Parse(recordTime).AddHours(-8);
                para.Add("lastUpdateTime", lastUpdateTime);
                var students = _repository.Query("select * from student where updatetime>@lastUpdateTime", para);
                _elasticClient = scope.ServiceProvider.GetService<IElasticClient>();
                foreach (var student in students)
                {
                   //docker run -d --name elasticsearch -v /d/dockerData/elasticsearch/config:/usr/share/elasticsearch/config -v /d/dockerData/elasticsearch/plugins:/usr/share/elasticsearch/plugins - p 9200:9200 - p 9300:9300 - e "discovery.type=single-node" elasticsearch: 7.7.0
                    var response = _elasticClient.Index(student, idx => idx.Index("students"));
                    if (response.IsValid) {
                        
                        File.WriteAllText(filePath,DateTime.Now.ToString());
                    }
                    
                }
                
                var result = _elasticClient.Search<Student>(s =>
                    s.Index("students")
                );
                _logger.LogInformation(@$"----MedicationSync----{
                    JsonSerializer.Serialize(
                        result.Hits.Select(p => p.Source),
                        new JsonSerializerOptions {
                            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)


                        })}");
            }
            
            
            
           
        }
        public override void Dispose()
        {
            base.Dispose();
            _timer.Dispose();
        }
    }
}

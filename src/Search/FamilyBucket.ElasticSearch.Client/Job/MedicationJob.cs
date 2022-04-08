using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FamilyBucket.ElasticSearch.Client.Job
{
    public class MedicationJob : BackgroundService
    {
        private readonly ILogger<MedicationJob> _logger;
        private Timer _timer;

        public MedicationJob(ILogger<MedicationJob> logger)
        {
            _logger = logger;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _timer = new Timer(MedicationSync, null, TimeSpan.Zero, TimeSpan.FromSeconds(5));
            return Task.CompletedTask;
        }
        private void MedicationSync(object state)
        {
            _logger.LogInformation($"----MedicationSync----");
        }
        public override void Dispose()
        {
            base.Dispose();
            _timer.Dispose();
        }
    }
}

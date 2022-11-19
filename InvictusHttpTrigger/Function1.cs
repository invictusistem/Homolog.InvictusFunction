using System;
using System.Net.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace InvictusHttpTrigger
{
    public class Function1
    {
        [FunctionName("Function1")]
        public void Run([TimerTrigger("00:05:00")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
            var http = new HttpClient();

            var resp = http.GetAsync("https://invictus-api-hml.azurewebsites.net/api/dev/trigger").Result;

        }
    }
}

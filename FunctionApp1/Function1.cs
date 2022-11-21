using System;
using System.Net.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using static System.Net.WebRequestMethods;

namespace FunctionApp1
{
    public class Function1
    {
        [FunctionName("Function1")]
        public void Run([TimerTrigger("0 45 2 * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");

            var http = new HttpClient();
            var resp = http.GetAsync("https://invictus-api-hml.azurewebsites.net/api/dev/trigger").Result;
        }
    }
}

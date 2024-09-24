using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;                   // For IActionResult and OkObjectResult
using Microsoft.Azure.WebJobs;                    // For FunctionName, HttpTrigger, etc.
using Microsoft.Azure.WebJobs.Extensions.Http;    // For HttpTrigger binding
using Microsoft.AspNetCore.Http;                  // For HttpRequest
using Microsoft.Extensions.Logging;
using System.Net.Http;
using Microsoft.Azure.Cosmos;
using Newtonsoft.Json;
using System.Text;               // For ILogger


// backendworkflow test comment11
namespace Company.Function
{
    public static class GetResumeCounter
    {
        [FunctionName("GetResumeCounter")]
        public static HttpResponseMessage Run (
            [HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req,
            [CosmosDB(
                databaseName: "AzureResume",
                containerName: "counter",
                Connection = "AzureResumeConnectionString",
                Id = "1",
                PartitionKey = "1"
            )] Counter counter,
            [CosmosDB(
                databaseName: "AzureResume",
                containerName: "counter",
                Connection = "AzureResumeConnectionString",
                Id = "1",
                PartitionKey = "1"
            )] out Counter updateCounter,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");
            if (counter == null)
            {
                log.LogInformation("Counter not found, initializing a new one.");
                updateCounter = new Counter
                {
                    id = "1",
                    count = 1  // Start the count from 1
                };
            }
            else
            {
                // Increment the count
                updateCounter = counter;
                updateCounter.count += 1;
            }
            var jsonToReturn = JsonConvert.SerializeObject(updateCounter);


            return new HttpResponseMessage(System.Net.HttpStatusCode.OK){
                Content = new StringContent(jsonToReturn,Encoding.UTF8,"application/json")          
            };
        }  
          
        
    }
}

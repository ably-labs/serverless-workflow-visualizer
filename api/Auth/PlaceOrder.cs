using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace Pizza.Order
{
    public class PlaceOrder
    {
        private HttpClient _httpClient;

        public PlaceOrder(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("Workflow");
        }

        [FunctionName(nameof(PlaceOrder))]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post")] HttpRequestMessage req,
            ILogger log)
        {
            var reponse = await _httpClient.PostAsync($"api/StartWorkflow", req.Content);
            var orchestrationId = reponse.Content.ReadAsStringAsync();
            return new OkObjectResult(orchestrationId);
        }
    }
}

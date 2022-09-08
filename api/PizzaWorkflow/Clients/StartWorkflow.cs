using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using PizzaWorkflow.Orchestrators;
using PizzaWorkflow.Models;

namespace PizzaWorkflow.Clients
{
    public static class StartWorkflow
    {
        [FunctionName(nameof(StartWorkflow))]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] Order order,
            [DurableClient] IDurableClient durableClient)
        {
            if (order.MenuItems != null)
            {
                var id = await durableClient.StartNewAsync(
                    nameof(PizzaWorkflowOrchestrator),
                    order);

                return new OkObjectResult($"Start processing order {id}.");
            }
            else
            {
                return new BadRequestObjectResult("Please provide menuItems in the request.");
            }
        }
    }
}

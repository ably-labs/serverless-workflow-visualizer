using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Extensions.Logging;
using IO.Ably;
using PizzaWorkflow.Models;
using System.Threading;
using System;

namespace PizzaWorkflow.Activities
{
    public class PreparePizza : MessagingBase
    {
        public PreparePizza(IRestClient ablyClient) : base(ablyClient)
        {
        }

        [FunctionName(nameof(PreparePizza))]
        public async Task Run(
            [ActivityTrigger] Instructions instructions,
            ILogger logger)
        {
            logger.LogInformation($"Preparing {instructions.MenuItem.Name}.");
            Thread.Sleep(new Random().Next(5000, 10000));
            await base.PublishAsync(instructions.OrderId, "prepare-pizza", instructions);
        }
    }
}
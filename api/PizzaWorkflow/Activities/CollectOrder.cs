using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Extensions.Logging;
using IO.Ably;
using PizzaWorkflow.Models;
using System;
using System.Threading;

namespace PizzaWorkflow.Activities
{
    public class CollectOrder : MessagingBase
    {
        public CollectOrder(IRestClient ablyClient) : base(ablyClient)
        {
        }

        [FunctionName(nameof(CollectOrder))]
        public async Task Run(
            [ActivityTrigger] Order order,
            ILogger logger)
        {
            logger.LogInformation($"Collect menu items for order {order.Id}.");
            Thread.Sleep(new Random().Next(3000, 6000));
            await base.PublishAsync(order.Id, "collect-order", new WorkflowState(order.Id));
        }
    }
}
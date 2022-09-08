using System;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Extensions.Logging;
using IO.Ably;
using PizzaWorkflow.Models;

namespace PizzaWorkflow.Activities
{
    public class DeliverOrder : MessagingBase
    {
        public DeliverOrder(IRestClient ablyClient) : base(ablyClient)
        {
        }

        [FunctionName(nameof(DeliverOrder))]
        public async Task Run(
            [ActivityTrigger] Order order,
            ILogger logger)
        {
            logger.LogInformation($"Handing over order {order.Id} to delivery.");
            await base.PublishAsync(order.Id, "deliver-order", order);
        }
    }
}
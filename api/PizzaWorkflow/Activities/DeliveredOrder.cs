using System;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Extensions.Logging;
using IO.Ably;
using PizzaWorkflow.Models;
using System.Threading;

namespace PizzaWorkflow.Activities
{
    public class DeliveredOrder : MessagingBase
    {
        public DeliveredOrder(IRestClient ablyClient) : base(ablyClient)
        {
        }

        [FunctionName(nameof(DeliveredOrder))]
        public async Task Run(
            [ActivityTrigger] Order order,
            ILogger logger)
        {
            logger.LogInformation($"Delivered {order.Id}.");
            Thread.Sleep(new Random().Next(3000, 6000));
            await base.PublishAsync(order.Id, "delivered-order", new WorkflowState(order.Id));
        }
    }
}
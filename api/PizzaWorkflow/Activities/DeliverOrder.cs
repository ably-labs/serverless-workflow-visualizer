using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Extensions.Logging;
using IO.Ably;
using Ably.PizzaProcess.Models;

namespace Ably.PizzaProcess.Activities
{
    public class DeliverOrder
    {
        private readonly IRestClient _ablyClient;

        public DeliverOrder(IRestClient ablyClient)
        {
            _ablyClient = ablyClient;
        }

        [FunctionName(nameof(DeliverOrder))]
        public async Task Run(
            [ActivityTrigger] Order order,
            ILogger logger)
        {
            logger.LogInformation($"Handing over order {order.Id} to delivery.");
            var channel = _ablyClient.Channels.Get(Environment.GetEnvironmentVariable("ABLY_CHANNEL_PREFIX"));
            await channel.PublishAsync("deliver-order", order);
        }
    }
}
using System;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Extensions.Logging;
using IO.Ably;
using Ably.PizzaProcess.Models;

namespace Ably.PizzaProcess.Activities
{
    public class CollectMenuItems
    {
        private readonly IRestClient _ablyClient;

        public CollectMenuItems(IRestClient ablyClient)
        {
            _ablyClient = ablyClient;
        }

        [FunctionName(nameof(CollectMenuItems))]
        public async Task Run(
            [ActivityTrigger] Order order,
            ILogger logger)
        {
            logger.LogInformation($"Collect menu items for order {order.Id}.");
            var channel = _ablyClient.Channels.Get(Environment.GetEnvironmentVariable("ABLY_CHANNEL_NAME"));
            await channel.PublishAsync("collect-menuitems", order);
        }
    }
}
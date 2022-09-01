using System;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Extensions.Logging;
using IO.Ably;
using Ably.PizzaProcess.Models;

namespace Ably.PizzaProcess.Activities
{
    public class OrderIsReady
    {
        private readonly IRestClient _ablyClient;

        public OrderIsReady(IRestClient ablyClient)
        {
            _ablyClient = ablyClient;
        }

        [FunctionName(nameof(OrderIsReady))]
        public async Task Run(
            [ActivityTrigger] Order order,
            ILogger logger)
        {
            logger.LogInformation($"Order {order.Id} is ready.");
            var channel = _ablyClient.Channels.Get(Environment.GetEnvironmentVariable("ABLY_CHANNEL_NAME"));
            await channel.PublishAsync("order-ready", order);
        }
    }
}
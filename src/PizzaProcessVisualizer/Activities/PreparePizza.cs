using System;
using System.Threading.Tasks;
using Ably.PizzaProcess.Models;
using IO.Ably;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Extensions.Logging;

namespace Ably.PizzaProcess.Activities
{
    public class PreparePizza
    {
        private readonly IRestClient _ablyClient;

        public PreparePizza(IRestClient ablyClient)
        {
            _ablyClient = ablyClient;
        }

        [FunctionName(nameof(PreparePizza))]
        public async Task Run(
            [ActivityTrigger] Instructions instructions,
            ILogger logger)
        {
            logger.LogInformation($"Preparing {instructions.MenuItem.Name}.");
            var channel = _ablyClient.Channels.Get(Environment.GetEnvironmentVariable("ABLY_CHANNEL_NAME"));
            await channel.PublishAsync("prepare-pizza", instructions);
        }
    }
}
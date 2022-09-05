using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ably.PizzaProcess.Models;
using IO.Ably;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Extensions.Logging;

namespace Ably.PizzaProcess.Activities
{
    public class SendInstructionsToKitchen
    {
        private readonly IRestClient _ablyClient;

        public SendInstructionsToKitchen(IRestClient ablyClient)
        {
            _ablyClient = ablyClient;
        }

        [FunctionName(nameof(SendInstructionsToKitchen))]
        public async Task Run(
            [ActivityTrigger] IEnumerable<Instructions> instructions,
            ILogger logger)
        {
            logger.LogInformation($"Sending instructions to kitchen.");
            var channel = _ablyClient.Channels.Get(Environment.GetEnvironmentVariable("ABLY_CHANNEL_NAME"));
            await channel.PublishAsync("send-instructions-to-kitchen", instructions);
        }
    }
}
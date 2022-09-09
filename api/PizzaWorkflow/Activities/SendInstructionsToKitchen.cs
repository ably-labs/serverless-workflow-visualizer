using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Extensions.Logging;
using IO.Ably;
using PizzaWorkflow.Models;
using System.Linq;

namespace PizzaWorkflow.Activities
{
    public class SendInstructionsToKitchen : MessagingBase
    {
        public SendInstructionsToKitchen(IRestClient ablyClient) : base(ablyClient)
        {
        }

        [FunctionName(nameof(SendInstructionsToKitchen))]
        public async Task Run(
            [ActivityTrigger] IEnumerable<Instructions> instructions,
            ILogger logger)
        {
            logger.LogInformation($"Sending instructions to kitchen.");
            await base.PublishAsync(instructions.First().OrderId, "send-instructions-to-kitchen", instructions);
        }
    }
}
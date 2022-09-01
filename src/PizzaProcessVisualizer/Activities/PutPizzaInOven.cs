using System.Threading.Tasks;
using Ably.PizzaProcess.Models;
using IO.Ably;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Extensions.Logging;

namespace Ably.PizzaProcess.Activities
{
    public class PutPizzaInOven
    {
        private readonly IRestClient _ablyClient;

        public PutPizzaInOven(IRestClient ablyClient)
        {
            _ablyClient = ablyClient;
        }

        [FunctionName(nameof(PutPizzaInOven))]
        public async Task Run(
            [ActivityTrigger] Instructions instructions,
            ILogger logger)
        {
            logger.LogInformation($"Putting {instructions.MenuItem.Name} in the oven.");

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Extensions.Logging;
using PizzaProcessVizualizer.Models;

namespace PizzaProcessVizualizer
{
    public class SendInstructionsToKitchen
    {
        [FunctionName(nameof(SendInstructionsToKitchen))]
        public async Task Run(
            [ActivityTrigger] Instructions instruction,
            ILogger logger)
        {
            
            // TODO
        }
    }
}
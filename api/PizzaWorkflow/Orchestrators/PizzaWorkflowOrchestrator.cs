using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using PizzaWorkflow.Activities;
using PizzaWorkflow.Models;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Extensions.Logging;

namespace PizzaWorkflow.Orchestrators
{
    public class PizzaWorkflowOrchestrator
    {
        [FunctionName(nameof(PizzaWorkflowOrchestrator))]
        public async Task Run(
            [OrchestrationTrigger] IDurableOrchestrationContext context,
            ILogger logger)
        {
            var order = context.GetInput<Order>();

            var instructions = await context.CallActivityAsync<IEnumerable<Instructions>>(
                nameof(ReceiveOrder),
                order);

            await context.CallActivityAsync(
                    nameof(SendInstructionsToKitchen),
                    instructions);

            var preparationTasks = new List<Task>();
            foreach (var instruction in instructions)
            {
                if (instruction.MenuItem.Type == MenuItemType.Pizza)
                {
                    preparationTasks.Add(context.CallActivityAsync(
                        nameof(PreparePizza),
                        instruction));
                }
            }

            await Task.WhenAll(preparationTasks);

            await context.CallActivityAsync(
                nameof(CollectOrder),
                order);

            await context.CallActivityAsync(
                nameof(DeliverOrder),
                order);
        }
    }
}
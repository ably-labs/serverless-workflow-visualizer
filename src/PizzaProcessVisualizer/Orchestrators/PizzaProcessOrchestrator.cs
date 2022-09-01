using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ably.PizzaProcess.Activities;
using Ably.PizzaProcess.Clients;
using Ably.PizzaProcess.Models;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Extensions.Logging;

namespace Ably.PizzaProcess.Orchestrators
{
    public class PizzaProcessOrchestrator
    {
        [FunctionName(nameof(PizzaProcessOrchestrator))]
        public async Task Run(
            [OrchestrationTrigger] IDurableOrchestrationContext context,
            ILogger logger)
        {
            var order = context.GetInput<Order>();
            order.Id = context.InstanceId;

            var instructions = await context.CallActivityAsync<IEnumerable<Instructions>>(
                nameof(PrepareInstructions),
                order);
            
            var instructionToKitchenTasks = new List<Task>();
            foreach (var instruction in instructions)
            {
                instructionToKitchenTasks.Add(context.CallActivityAsync(
                    nameof(SendInstructionsToKitchen),
                    instruction));
            }
            await Task.WhenAll(instructionToKitchenTasks);
            
            var pizzaInOvenTasks = new List<Task>();
            foreach (var instruction in instructions)
            {
                if (instruction.MenuItem.Type == MenuItemType.Pizza)
                {
                    pizzaInOvenTasks.Add(context.CallActivityAsync(
                        nameof(PutPizzaInOven),
                        instruction));
                }
            }

            await Task.WhenAll(pizzaInOvenTasks);

            // Simulate the time it takes to prepare the order
            await context.CreateTimer(context.CurrentUtcDateTime.AddSeconds(new Random().Next(1, 2)), CancellationToken.None);
            await context.CallActivityAsync(nameof(OrderIsReady));

            await context.CallActivityAsync(
                nameof(HandOverToDelivery), 
                order);

            await context.CallActivityAsync(nameof(OrderIsDelivered));
        }
    }
}
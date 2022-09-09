using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using IO.Ably;
using PizzaWorkflow.Models;

namespace PizzaWorkflow.Activities
{
    public class ReceiveOrder : MessagingBase
    {
        public ReceiveOrder(IRestClient ablyClient) : base(ablyClient)
        {
        }

        [FunctionName(nameof(ReceiveOrder))]
        public async Task<List<Instructions>> Run(
            [ActivityTrigger] Order order)
        {
            var instructions = new List<Instructions>();
            foreach (var menuItem in order.MenuItems)
            {
                (int timeInMinutes, int temperatureInCelsius) bakingInstructions = GetBakingInstructions(menuItem);
                instructions.Add(
                    new Instructions
                    {
                        BakingTimeMinutes = bakingInstructions.timeInMinutes,
                        BakingTemperatureCelsius = bakingInstructions.temperatureInCelsius,
                        MenuItem = menuItem,
                        OrderId = order.Id
                    });
            }

            await base.PublishAsync(order.Id, "receive-order", order);

            return instructions;
        }

        private (int timeInMinutes, int temperatureInCelsius) GetBakingInstructions(MenuItem menuItem)
        {
            if (menuItem.Type == MenuItemType.Pizza)
            {
                var random = new Random();
                return (random.Next(10, 20), random.Next(180, 220));
            }
            else
            {
                return (0, 0);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using IO.Ably;
using Ably.PizzaProcess.Models;

namespace Ably.PizzaProcess.Activities
{
    public class ReceiveOrder
    {
        private readonly IRestClient _ablyClient;

        public ReceiveOrder(IRestClient ablyClient)
        {
            _ablyClient = ablyClient;
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
                        OrderId = order.Id,
                        RestaurantId = order.RestaurantId
                    });
            }

            var channel = _ablyClient.Channels.Get(Environment.GetEnvironmentVariable("ABLY_CHANNEL_NAME"));
            await channel.PublishAsync("receive-order", order);

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
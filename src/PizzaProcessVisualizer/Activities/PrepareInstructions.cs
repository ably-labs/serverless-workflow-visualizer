using System;
using System.Collections.Generic;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using IO.Ably;
using Ably.PizzaProcess.Models;

namespace Ably.PizzaProcess.Activities
{
    public class PrepareInstructions
    {
        private readonly IRestClient _ablyClient;

        public PrepareInstructions(IRestClient ablyClient)
        {
            _ablyClient = ablyClient;
        }

        [FunctionName(nameof(PrepareInstructions))]
        public IEnumerable<Instructions> Run(
            [ActivityTrigger] Order order)
        {
            foreach (var menuItem in order.MenuItems)
            {
                (int timeInMinutes, int temperatureInCelsius) bakingInstructions = GetBakingInstructions(menuItem);
                yield return new Instructions
                {
                    BakingTimeMinutes = bakingInstructions.timeInMinutes,
                    BakingTemperatureCelsius = bakingInstructions.temperatureInCelsius,
                    MenuItem = menuItem,
                    OrderId = order.Id,
                    RestaurantId = order.RestaurantId
                };
            }
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
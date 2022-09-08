using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Extensions.Logging;
using IO.Ably;
using PizzaWorkflow.Models;

namespace PizzaWorkflow.Activities
{
    public class CollectMenuItems : MessagingBase
    {
        public CollectMenuItems(IRestClient ablyClient) : base(ablyClient)
        {
        }

        [FunctionName(nameof(CollectMenuItems))]
        public async Task Run(
            [ActivityTrigger] Order order,
            ILogger logger)
        {
            logger.LogInformation($"Collect menu items for order {order.Id}.");
            await base.PublishAsync(order.Id, "collect-menuitems", order);
        }
    }
}
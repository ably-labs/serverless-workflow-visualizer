using System;
using System.Threading.Tasks;
using IO.Ably;

namespace PizzaWorkflow.Activities
{
    public abstract class MessagingBase
    {
        private readonly IRestClient _ablyClient;

        protected MessagingBase(IRestClient ablyClient)
        {
            _ablyClient = ablyClient;
        }

        protected async Task PublishAsync(string orderId, string eventName, object data)
        {
            var channelName = $"{Environment.GetEnvironmentVariable("ABLY_CHANNEL_PREFIX")}:{orderId}";
            var channel = _ablyClient.Channels.Get(channelName);
            await channel.PublishAsync(eventName, data);
        }
    }
}
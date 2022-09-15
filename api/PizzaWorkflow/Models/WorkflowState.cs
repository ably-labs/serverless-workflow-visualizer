using System;
using Newtonsoft.Json;

namespace PizzaWorkflow.Models
{
    public class WorkflowState
    {
        public WorkflowState(string orderId)
        {
            OrderId = orderId;
            MessageSentTimeStampUTC = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
        }

        [JsonProperty("orderId")]
        public string OrderId { get; set; }

        [JsonProperty("messageSentTimeStampUTC")]
        public long MessageSentTimeStampUTC { get; set; }
    }
}
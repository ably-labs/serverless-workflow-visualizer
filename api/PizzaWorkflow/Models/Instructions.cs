using Newtonsoft.Json;

namespace PizzaWorkflow.Models
{
    public class Instructions
    {
        [JsonProperty("orderId")]
        public string OrderId { get; set; }
        [JsonProperty("menuItem")]
        public MenuItem MenuItem { get; set; }
        [JsonProperty("bakingTimeMinutes")]
        public int BakingTimeMinutes { get; set; }
        [JsonProperty("bakingTemperatureCelsius")]
        public int BakingTemperatureCelsius { get; set; }
    }
}
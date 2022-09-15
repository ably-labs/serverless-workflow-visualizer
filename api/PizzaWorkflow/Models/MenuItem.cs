using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PizzaWorkflow.Models
{
    public class MenuItem
    {
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MenuItemType Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
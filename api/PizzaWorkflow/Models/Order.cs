using Newtonsoft.Json;

namespace PizzaWorkflow.Models
{
    public class Order
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        public string CustomerName { get; set; }
        [JsonProperty("customerAddress")]
        public string CustomerAddress { get; set; }
        [JsonProperty("menuItems")]
        public MenuItem[] MenuItems { get; set; }
    }
}
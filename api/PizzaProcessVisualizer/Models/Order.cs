using Newtonsoft.Json;

namespace Ably.PizzaProcess.Models
{
    public class Order
    {
        public Order()
        {
        }

        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("restaurantId")]
        public string RestaurantId { get; set; }
        [JsonProperty("customerName")]
        public string CustomerName { get; set; }
        [JsonProperty("customerAddress")]
        public string CustomerAddress { get; set; }
        [JsonProperty("menuItems")]
        public MenuItem[] MenuItems { get; set; }
    }
}
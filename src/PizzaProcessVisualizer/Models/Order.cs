namespace Ably.PizzaProcess.Models
{
    public class Order
    {
        public string Id { get; set; }
        public string RestaurantId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public MenuItem[] MenuItems { get; set; }
    }
}
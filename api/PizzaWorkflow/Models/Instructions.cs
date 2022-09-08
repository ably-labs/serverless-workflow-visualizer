namespace Ably.PizzaProcess.Models
{
    public class Instructions
    {
        public string  OrderId { get; set; }
        public string RestaurantId { get; set; }
        public MenuItem MenuItem { get; set; }
        public int BakingTimeMinutes { get; set; }
        public int BakingTemperatureCelsius { get; set; }
    }
}
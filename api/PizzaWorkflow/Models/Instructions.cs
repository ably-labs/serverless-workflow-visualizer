namespace PizzaWorkflow.Models
{
    public class Instructions
    {
        public string OrderId { get; set; }
        public MenuItem MenuItem { get; set; }
        public int BakingTimeMinutes { get; set; }
        public int BakingTemperatureCelsius { get; set; }
    }
}
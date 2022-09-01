namespace PizzaProcessVisualizer.Models
{
    public class OrderReadyEvent
    {
        public string OrderId { get; set; }
        public bool IsReady { get; set; }
    }
}
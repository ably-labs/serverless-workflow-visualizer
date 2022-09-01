namespace PizzaProcessVisualizer.Models
{
    public class OrderDeliveredEvent
    {
        public string OrderId { get; set; }
        public bool IsDelivered { get; set; }
    }
}
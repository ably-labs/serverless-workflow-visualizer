using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ably.PizzaProcess.Models
{
    public class MenuItem
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public MenuItemType Type { get; set; }

        public string Name { get; set; }
    }
}
using Newtonsoft.Json;

namespace Eldoed.Data
{
    public class JSONDishesList
    {
        [JsonProperty("data")]
        public JSONDishTemplate[] Data { get; set; }

    }
}

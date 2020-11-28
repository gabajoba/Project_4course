using Newtonsoft.Json;

namespace App2.Data
{
    public class JSONDishesList
    {
        [JsonProperty("data")]
        public JSONDishTemplate[] Data { get; set; }

    }
}

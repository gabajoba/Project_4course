using Newtonsoft.Json;

namespace App2.Data
{
    public class JSONuserInfo
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

    }
}

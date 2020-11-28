using Newtonsoft.Json;

namespace Eldoed.Data
{
    public class JSONauth
    {
        [JsonProperty("data")]
        public JSONuserInfo Data { get; set; }

        [JsonProperty("accessToken")]
        public string Token { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

    }
}

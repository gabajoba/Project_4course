using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace App2.Data
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

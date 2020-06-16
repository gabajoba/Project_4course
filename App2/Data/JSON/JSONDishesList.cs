using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace App2.Data
{
    public class JSONDishesList
    {
        [JsonProperty("data")]
        public JSONDishTemplate[] Data { get; set; }
    }
}

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Bitly.NoUse
{
    public class BitlyExpandData
    {
        [JsonProperty("global_hash")]
        public string GlobalHash { get; set; }

        [JsonProperty("long_url")]
        public string LongUrl { get; set; }

        [JsonProperty("short_url")]
        public string ShortUrl { get; set; }

        [JsonProperty("user_hash")]
        public string UserHash { get; set; }
    }
}
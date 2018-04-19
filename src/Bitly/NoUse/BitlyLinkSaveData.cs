using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Bitly.NoUse
{
    public class BitlyLinkSaveData
    {
        [JsonProperty("new_link")]
        public int NewLink { get; set; }

        [JsonProperty("aggregate_link")]
        public string AggregateLink { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("long_url")]
        public string LongUrl { get; set; }
    }
}
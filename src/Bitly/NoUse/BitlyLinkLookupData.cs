using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Bitly.NoUse
{
    public class BitlyLinkLookupData
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("aggregate_link")]
        public string AggregateLink { get; set; }
    }
}
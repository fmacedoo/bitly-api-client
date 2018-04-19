using System;
using System.Net.Http;
using Newtonsoft.Json;

namespace Bitly.Responses
{
    public class BitlyShortenResponse : BitlyResponse
    {
        [JsonProperty("data")]
        public ShortenData Data { get; set; }

        public class ShortenData
        {
            [JsonProperty("new_hash")]
            public int NewHash { get; set; }

            [JsonProperty("url")]
            public string Url { get; set; }

            [JsonProperty("hash")]
            public string Hash { get; set; }

            [JsonProperty("global_hash")]
            public string GlobalHash { get; set; }

            [JsonProperty("long_url")]
            public string LongUrl { get; set; }
        }
    }
}

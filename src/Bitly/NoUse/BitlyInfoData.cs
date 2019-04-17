using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Bitly.NoUse
{
    public class BitlyInfoData
    {
        [JsonProperty("short_url")]
        public string ShortUrl { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("user_hash")]
        public string UserHash { get; set; }

        [JsonProperty("global_hash")]
        public string GlobalHash { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }
}
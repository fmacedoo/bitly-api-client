using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Bitly.NoUse
{
    public class BitlyLinkHistoryItem
    {
        [JsonProperty("keyword_link")]
        public string KeyworkLink { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("aggregate_link")]
        public string AggregateLink { get; set; }

        [JsonProperty("long_url")]
        public string LongUrl { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("Private")]
        public bool IsPrivate  { get; set; }

        [JsonProperty("created_at")]
        public long CreatedAt { get; set; }

        [JsonProperty("user_ts")]
        public long UserTs { get; set; }

        [JsonProperty("modified_at")]
        public long? ModifiedAt { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("shares")]
        public List<string> Shares { get; set; }

        [JsonProperty("client_id")]
        public string ClientId { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }
    }
}
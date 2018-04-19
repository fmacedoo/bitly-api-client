using System;
using Newtonsoft.Json;

namespace Bitly.NoUse
{
    public class BitlyResponse
    {
        [JsonProperty("status_code")]
        public int StatusCode { get; set; }

        [JsonProperty("data")]
        public BitlyResponseData Data { get; set; }

        [JsonProperty("status_txt")]
        public string Status { get; set; }
    }
}

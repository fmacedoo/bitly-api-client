using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;

namespace Bitly.Responses
{
    public class BitlyResponse
    {
        [JsonProperty("status_code")]
        public int StatusCode { get; set; }

        [JsonProperty("status_txt")]
        public string Status { get; set; }
    }
}
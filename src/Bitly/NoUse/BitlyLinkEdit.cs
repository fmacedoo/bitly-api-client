using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Bitly.NoUse
{
    public class BitlyLinkEdit
    {
        [JsonProperty("link")]
        public string Link { get; set; }
    }
}
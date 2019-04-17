using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Bitly.NoUse
{
    public class BityShareAccount
    {
        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        [JsonProperty("account_login")]
        public string AccountLogin { get; set; }

        [JsonProperty("account_name")]
        public string AccountName { get; set; }

        [JsonProperty("account_type")]
        public string AccountType { get; set; }

        [JsonProperty("auto_import_links")]
        public bool AutoImportLinks { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("numeric_id")]
        public long NumericId { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("visible")]
        public bool Visible { get; set; }
    }

}
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Bitly;

namespace Bitly.NoUse
{
    public class BitlyResponseData
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

        
        [JsonProperty("apiKey")]
        public string APIKey { get; set; }

        [JsonProperty("custom_short_domain")]
        public string CustomShortDomain { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("is_enterprise")]
        public bool IsEnterprise { get; set; }

        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("member_since")]
        public double MemberSince { get; set; }

        [JsonProperty("profile_image")]
        public string ProfileImage { get; set; }

        [JsonProperty("profile_url")]
        public string ProfileUrl { get; set; }

        [JsonProperty("share_accounts")]
        public List<BityShareAccount> ShareAccounts { get; set; }

        [JsonProperty("apiKey")]
        public List<string> tracking_domains { get; set; }

        [JsonProperty("apiKey")]
        public string default_link_privacy { get; set; }
        

        [JsonProperty("result_count")]
        public long ResultCount { get; set; }

        [JsonProperty("domain_options")]
        public List<string> DomainOptions { get; set; }

        [JsonProperty("expand")]
        public List<BitlyExpandData> Expand { get; set; }

        [JsonProperty("info")]
        public List<BitlyInfoData> Info { get; set; }

        [JsonProperty("link_lookup")]
        public List<BitlyLinkLookupData> LinkLookup { get; set; }

        [JsonProperty("link_save")]
        public BitlyLinkSaveData LinkSave { get; set; }

        [JsonProperty("link_history")]
        public List<BitlyLinkHistoryItem> LinkHistory { get; set; }

        [JsonProperty("link_edit")]
        public BitlyLinkEdit LinkEdit { get; set; }
    }
}
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Bybit.Net.Objects.Models
{
    /// <summary>
    /// Deposit address info
    /// </summary>
    public class BybitDepositAddress
    {
        /// <summary>
        /// The asset 
        /// </summary>
        [JsonProperty("coin")]
        public string Asset { get; set; } = string.Empty;
        /// <summary>
        /// Available network adresses
        /// </summary>
        [JsonProperty("chains")]
        public IEnumerable<BybitNetworkDepositAddress> Networks { get; set; } = Array.Empty<BybitNetworkDepositAddress>();
    }

    /// <summary>
    /// ApiKey info
    /// </summary>
    public class BybitApiKeyInfo
    {
        public string Id { get; set; }
        public string Note { get; set; }
        public string ApiKey { get; set; }
        public int ReadOnly { get; set; }
        public string Secret { get; set; }
        public int Type { get; set; }
        public int DeadlineDay { get; set; }
        public DateTime ExpiredAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Unified { get; set; }
        public int Uta { get; set; }
        public long UserID { get; set; }
        public int InviterID { get; set; }
        public string VipLevel { get; set; }
        public string MktMakerLevel { get; set; }
        public int AffiliateID { get; set; }
    }
}

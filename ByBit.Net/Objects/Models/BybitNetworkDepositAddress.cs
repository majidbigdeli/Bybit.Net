using Newtonsoft.Json;

namespace Bybit.Net.Objects.Models
{
    /// <summary>
    /// Deposit address on a network
    /// </summary>
    public class BybitNetworkDepositAddress
    {
        /// <summary>
        /// Network type
        /// </summary>
        [JsonProperty("chainType")]
        public string NetworkType { get; set; } = string.Empty;
        /// <summary>
        /// Deposit address
        /// </summary>
        [JsonProperty("addressDeposit")]
        public string Address { get; set; } = string.Empty;
        /// <summary>
        /// Tag to use for deposit
        /// </summary>
        [JsonProperty("tagDeposit")]
        public string DepositTag { get; set; } = string.Empty;
        /// <summary>
        /// Network
        /// </summary>
        [JsonProperty("chain")]
        public string Network { get; set; } = string.Empty;
    }
}

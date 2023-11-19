﻿using Bybit.Net.Converters;
using CryptoExchange.Net.Converters;
using Newtonsoft.Json;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Marging status and leverage info
    /// </summary>
    public class BybitSpotMarginLeverageStatus
    {
        /// <summary>
        /// The leverage
        /// </summary>
        [JsonProperty("spotLeverage")]
        public decimal? Leverage { get; set; }
        /// <summary>
        /// Is spot margin mode activated
        /// </summary>
        [JsonProperty("spotMarginMode"), JsonConverter(typeof(BoolConverter))]
        public bool SpotMarginMode { get; set; }
    }
}

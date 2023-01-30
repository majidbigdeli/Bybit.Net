using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Bybit.Net.Objects.Models.Spot.v3
{
    /// <summary>
    /// Wrapper for symbols deserialization
    /// </summary>
    public class BybitSpotOrderWrapper
    {
        /// <summary>
        /// List of spot orders
        /// </summary>
        [JsonProperty("list")]
        public IEnumerable<BybitSpotOrderV3> Orders { get; set; } = Array.Empty<BybitSpotOrderV3>();
    }
}

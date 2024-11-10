using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Bybit.Net.Objects.Models.Spot.v3
{
    /// <summary>
    /// Spot trade info
    /// </summary>
    public record BybitSpotTradeV3
    {
        /// <summary>
        /// Trade price
        /// </summary>
        [JsonProperty("price")]
        public decimal Price { get; set; }
        /// <summary>
        /// Timestamp of the trade
        /// </summary>
        [JsonProperty("time"), JsonConverter(typeof(DateTimeConverter))]
        public DateTime TradeTime { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [JsonProperty("qty")]
        public decimal Quantity { get; set; }
        /// <summary>
        /// Is the buyer the maker
        /// </summary>
        public int IsBuyerMaker { get; set; }
    }



    /// <summary>
    /// User trade info
    /// </summary>
    public class BybitSpotUserTradeV3
    {

        /// <summary>
        /// Symbol
        /// </summary>
        public string Symbol { get; set; } = string.Empty;

        /// <summary>
        /// Trade id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Order id
        /// </summary>
        public long OrderId { get; set; }
        /// <summary>
        /// Trade id
        /// </summary>
        public long TradeId { get; set; }
        /// <summary>
        /// Trade price
        /// </summary>

        [JsonProperty("orderPrice")]
        public decimal Price { get; set; }
        /// <summary>
        /// Trade quantity
        /// </summary>
        [JsonProperty("orderQty")]
        public decimal Quantity { get; set; }
        /// <summary>
        /// Fee
        /// </summary>
        [JsonProperty("execFee")]
        public decimal Fee { get; set; }
        /// <summary>
        /// Fee asset
        /// </summary>
        [JsonProperty("feeTokenId")]
        public string FeeAsset { get; set; } = string.Empty;
        /// <summary>
        /// Trade time
        /// </summary>
        [JsonProperty("creatTime"), JsonConverter(typeof(DateTimeConverter))]
        public DateTime TradeTime { get; set; }
        /// <summary>
        /// Is buyer
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool IsBuyer { get; set; }
        /// <summary>
        /// Is maker
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool IsMaker { get; set; }

        /// <summary>
        /// Match OrderId 
        /// </summary>
        public long MatchOrderId { get; set; }
        /// <summary>
        /// Maker rebate
        /// </summary>
        public decimal MakerRebate { get; set; }

        /// <summary>
        /// Execution Time
        /// </summary>
        [JsonProperty("executionTime"), JsonConverter(typeof(DateTimeConverter))]
        public DateTime ExecutionTime { get; set; }

    }


    public class BybitSpotUserTradeWrapper
    {
        /// <summary>
        /// List of spot orders
        /// </summary>
        [JsonProperty("list")]
        public IEnumerable<BybitSpotUserTradeV3> Trades { get; set; } = Array.Empty<BybitSpotUserTradeV3>();
    }

}

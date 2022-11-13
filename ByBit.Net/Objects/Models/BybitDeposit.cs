﻿using Bybit.Net.Enums;
using CryptoExchange.Net.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Bybit.Net.Objects.Models
{
    /// <summary>
    /// Deposit info
    /// </summary>
    public class BybitDeposit
    {
        /// <summary>
        /// Asset
        /// </summary>
        [JsonProperty("coin")]
        public string Asset { get; set; } = string.Empty;
        /// <summary>
        /// Network
        /// </summary>
        [JsonProperty("chain")]
        public string Network { get; set; } = string.Empty;
        /// <summary>
        /// Quantity
        /// </summary>
        [JsonProperty("amount")]
        public decimal Quantity { get; set; }
        /// <summary>
        /// Transaction id
        /// </summary>
        [JsonProperty("txID")]
        public string TransactionId { get; set; } = string.Empty;
        /// <summary>
        /// Status
        /// </summary>
        [JsonConverter(typeof(EnumConverter))]
        public DepositStatus Status { get; set; }
        /// <summary>
        /// Address
        /// </summary>
        [JsonProperty("toAddress")]
        public string ToAddress { get; set; } = string.Empty;
        /// <summary>
        /// Tag
        /// </summary>
        public string Tag { get; set; } = string.Empty;
        /// <summary>
        /// Deposit fee
        /// </summary>
        [JsonProperty("depositFee")]
        public decimal? DepositFee { get; set; }
        /// <summary>
        /// Success time
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        [JsonProperty("successAt")]
        public DateTime SuccessTime { get; set; }
        /// <summary>
        /// Number of confirmations
        /// </summary>
        public int Confirmations { get; set; }
        /// <summary>
        /// Transaction sequence number
        /// </summary>
        [JsonProperty("txIndex")]
        public string TransactionIndex { get; set; } = string.Empty;
        /// <summary>
        /// Hash number on the chain
        /// </summary>
        [JsonProperty("blockHash")]
        public string BlockHash { get; set; } = string.Empty;

    }
}

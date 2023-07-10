﻿using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Margin trading status
    /// </summary>
    public enum MarginTrading
    {
        /// <summary>
        /// No margin trading
        /// </summary>
        [Map("none")]
        None,
        /// <summary>
        /// Both normal and UTA account supports margin trading
        /// </summary>
        [Map("both")]
        Both,
        /// <summary>
        /// Only UTA account supports margin trading
        /// </summary>
        [Map("utaOnly")]
        UtaOnly,
        /// <summary>
        /// Only normal account support margin trading
        /// </summary>
        [Map("normalSpotOnly")]
        NormalSpotOnly
    }
}

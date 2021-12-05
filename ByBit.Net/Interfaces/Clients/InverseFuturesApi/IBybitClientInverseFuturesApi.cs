﻿using System;

namespace Bybit.Net.Clients.Rest.Futures
{
    /// <summary>
    /// Bybit inverse futures API endpoints
    /// </summary>
    public interface IBybitClientInverseFuturesApi : IDisposable
    {
        /// <summary>
        /// Endpoints related to account settings, info or actions
        /// </summary>
        IBybitClientInverseFuturesApiAccount Account { get; }

        /// <summary>
        /// Endpoints related to retrieving market and system data
        /// </summary>
        IBybitClientInverseFuturesApiExchangeData ExchangeData { get; }

        /// <summary>
        /// Endpoints related to orders and trades
        /// </summary>
        IBybitClientInverseFuturesApiTrading Trading { get; }
    }
}
﻿using Bybit.Net.Enums;
using Bybit.Net.Objects.Models;
using CryptoExchange.Net.Objects;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Bybit.Net.Interfaces.Clients.UsdPerpetualApi
{
    /// <summary>
    /// [DEPRECATED, WILL STOP WORKING ON 16 OCTOBER, USE V5 API INSTEAD] Bybit exchange data endpoints. Exchange data includes market data (tickers, order books, etc) and system status.
    /// </summary>
    public interface IBybitRestClientUsdPerpetualApiExchangeData
    {
        /// <summary>
        /// Get the server time
        /// <para><a href="https://bybit-exchange.github.io/docs/futuresV2/linear/#t-servertime" /></para>
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<DateTime>> GetServerTimeAsync(CancellationToken ct = default);

        /// <summary>
        /// The API announcements for the last 30 days
        /// <para><a href="https://bybit-exchange.github.io/docs/futuresV2/linear/#t-announcement" /></para>
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<IEnumerable<BybitAnnouncement>>> GetAnnouncementsAsync(CancellationToken ct = default);

        /// <summary>
        /// Get all supported symbols
        /// <para><a href="https://bybit-exchange.github.io/docs/futuresV2/linear/#t-querysymbol" /></para>
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<IEnumerable<BybitSymbol>>> GetSymbolsAsync(CancellationToken ct = default);

        /// <summary>
        /// The ticker info for a symbol
        /// <para><a href="https://bybit-exchange.github.io/docs/futuresV2/linear/#t-latestsymbolinfo" /></para>
        /// </summary>
        /// <param name="symbol">The symbol</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<IEnumerable<BybitTicker>>> GetTickerAsync(string? symbol = null, CancellationToken ct = default);

        /// <summary>
        /// Get the current order book for a symbol
        /// <para><a href="https://bybit-exchange.github.io/docs/futuresV2/linear/#t-orderbook" /></para>
        /// </summary>
        /// <param name="symbol">The symbol</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<IEnumerable<BybitOrderBookEntry>>> GetOrderBookAsync(string symbol, CancellationToken ct = default);

        /// <summary>
        /// Get public trade history
        /// <para><a href="https://bybit-exchange.github.io/docs/futuresV2/linear/#t-publictradingrecords" /></para>
        /// </summary>
        /// <param name="symbol">The symbol</param>
        /// <param name="limit">Max amount of results</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<IEnumerable<BybitTrade>>> GetTradeHistoryAsync(string symbol, int? limit = null, CancellationToken ct = default);

        /// <summary>
        /// Get price klines
        /// <para><a href="https://bybit-exchange.github.io/docs/futuresV2/linear/#t-querykline" /></para>
        /// </summary>
        /// <param name="symbol">Symbol of the klines</param>
        /// <param name="interval">Interval of the kline data</param>
        /// <param name="from">Start time of the data</param>
        /// <param name="limit">Max amount of candles</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<IEnumerable<BybitKline>>> GetKlinesAsync(string symbol, KlineInterval interval, DateTime from, int? limit = null, CancellationToken ct = default);

        /// <summary>
        /// Get index price klines
        /// <para><a href="https://bybit-exchange.github.io/docs/futuresV2/linear/#t-queryindexpricekline" /></para>
        /// </summary>
        /// <param name="symbol">Symbol of the klines</param>
        /// <param name="interval">Interval of the kline data</param>
        /// <param name="from">Start time of the data</param>
        /// <param name="limit">Max amount of candles</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<IEnumerable<BybitIndexPriceKline>>> GetIndexPriceKlinesAsync(string symbol, KlineInterval interval, DateTime from, int? limit = null, CancellationToken ct = default);

        /// <summary>
        /// Get mark price klines
        /// <para><a href="https://bybit-exchange.github.io/docs/futuresV2/linear/#t-markpricekline" /></para>
        /// </summary>
        /// <param name="symbol">Symbol of the klines</param>
        /// <param name="interval">Interval of the kline data</param>
        /// <param name="from">Start time of the data</param>
        /// <param name="limit">Max amount of candles</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<IEnumerable<BybitMarkPriceKline>>> GetMarkPriceKlinesAsync(string symbol, KlineInterval interval, DateTime from, int? limit = null, CancellationToken ct = default);

        /// <summary>
        /// Get premium index klines
        /// <para><a href="https://bybit-exchange.github.io/docs/futuresV2/linear/#t-querypremiumindexkline" /></para>
        /// </summary>
        /// <param name="symbol">Symbol of the klines</param>
        /// <param name="interval">Interval of the kline data</param>
        /// <param name="from">Start time of the data</param>
        /// <param name="limit">Max amount of candles</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<IEnumerable<BybitIndexPriceKline>>> GetPremiumIndexKlinesAsync(string symbol, KlineInterval interval, DateTime from, int? limit = null, CancellationToken ct = default);

        /// <summary>
        /// Get long/short ratio
        /// <para><a href="https://bybit-exchange.github.io/docs/futuresV2/linear/#t-marketaccountratio" /></para>
        /// </summary>
        /// <param name="symbol">The symbol</param>
        /// <param name="period">The data period</param>
        /// <param name="limit">Max amount of results</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<IEnumerable<BybitAccountRatio>>> GetLongShortRatioAsync(string symbol, DataPeriod period, int? limit = null, CancellationToken ct = default);

        /// <summary>
        /// Gets the total amount of unsettled contracts. In other words, the total number of contracts held in open positions.
        /// <para><a href="https://bybit-exchange.github.io/docs/futuresV2/linear/#t-marketopeninterest" /></para>
        /// </summary>
        /// <param name="symbol">The symbol</param>
        /// <param name="period">The period of data</param>
        /// <param name="limit">Max amount of results</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<IEnumerable<BybitOpenInterest>>> GetOpenInterestAsync(string symbol, DataPeriod period, int? limit = null, CancellationToken ct = default);

        /// <summary>
        /// Obtain filled orders worth more than 500,000 USD within the last 24h.
        /// <para><a href="https://bybit-exchange.github.io/docs/futuresV2/linear/#t-marketbigdeal" /></para>
        /// </summary>
        /// <param name="symbol">The symbol</param>
        /// <param name="limit">The max amount of results</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<IEnumerable<BybitBigTrade>>> GetRecentBigTradesAsync(string symbol, int? limit = null, CancellationToken ct = default);

        /// <summary>
        /// Get last funding rate
        /// <para><a href="https://bybit-exchange.github.io/docs/futuresV2/linear/#t-fundingrate" /></para>
        /// </summary>
        /// <param name="symbol">The symbol</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<BybitFundingRate>> GetLastFundingRateAsync(string symbol, CancellationToken ct = default);
    }
}
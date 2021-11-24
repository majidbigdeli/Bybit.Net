﻿using Bybit.Net.Converters;
using Bybit.Net.Enums;
using Bybit.Net.Objects.Internal;
using Bybit.Net.Objects.Models;
using CryptoExchange.Net;
using CryptoExchange.Net.Converters;
using CryptoExchange.Net.Objects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bybit.Net.Clients.Rest.Futures
{
    /// <summary>
    /// Spot system endpoints
    /// </summary>
    public class BybitClientFuturesBaseAccount 
    //: IBybitInversePerpetualClientAccount
    {
        protected readonly BybitClientFuturesBase _baseClient;

        internal BybitClientFuturesBaseAccount(BybitClientFuturesBase baseClient)
        {
            _baseClient = baseClient;
        }

        #region Get balances

        /// <inheritdoc />
        public async Task<WebCallResult<Dictionary<string, BybitBalance>>> GetBalancesAsync(string? asset = null, long? receiveWindow = null, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            parameters.AddOptionalParameter("coin", asset);
            parameters.AddOptionalParameter("recvWindow", receiveWindow?.ToString(CultureInfo.InvariantCulture) ?? _baseClient.ClientOptions.ReceiveWindow.TotalMilliseconds.ToString(CultureInfo.InvariantCulture));

            return await _baseClient.SendRequestAsync<Dictionary<string, BybitBalance>>(_baseClient.GetUrl("v2/private/wallet/balance"), HttpMethod.Get, ct, parameters, true).ConfigureAwait(false);
        }

        #endregion

        #region Get wallet fund history

        /// <inheritdoc />
        public async Task<WebCallResult<IEnumerable<BybitWalletFundRecord>>> GetWalletFundHistoryAsync(string? asset = null, DateTime? startTime = null, DateTime? endTime = null, WalletFundType? type = null, int? pageSize = null, int? page = null, long? receiveWindow = null, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            parameters.AddOptionalParameter("currency", asset);
            parameters.AddOptionalParameter("start_date", startTime?.ToString("yyyy-MM-dd"));
            parameters.AddOptionalParameter("end_date", endTime?.ToString("yyyy-MM-dd"));
            parameters.AddOptionalParameter("wallet_fund_type", type == null ? null : JsonConvert.SerializeObject(type, new WalletFundTypeConverter(false)));
            parameters.AddOptionalParameter("page", page?.ToString());
            parameters.AddOptionalParameter("limit", pageSize?.ToString());
            parameters.AddOptionalParameter("recvWindow", receiveWindow?.ToString(CultureInfo.InvariantCulture) ?? _baseClient.ClientOptions.ReceiveWindow.TotalMilliseconds.ToString(CultureInfo.InvariantCulture));

            var result = await _baseClient.SendRequestAsync<BybitData<IEnumerable<BybitWalletFundRecord>>>(_baseClient.GetUrl("v2/private/wallet/fund/records"), HttpMethod.Get, ct, parameters, true).ConfigureAwait(false);
            if (!result)
                return result.As<IEnumerable<BybitWalletFundRecord>>(default);

            if (result.Data.Data == null)
                return result.As<IEnumerable<BybitWalletFundRecord>>(new BybitWalletFundRecord[0]);

            return result.As(result.Data.Data);
        }

        #endregion

        #region Get withdrawal history

        /// <inheritdoc />
        public async Task<WebCallResult<IEnumerable<BybitWithdrawal>>> GetWithdrawalHistoryAsync(string? asset = null, DateTime? startTime = null, DateTime? endTime = null, WithdrawStatus? status = null, int? pageSize = null, int? page = null, long? receiveWindow = null, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            parameters.AddOptionalParameter("currency", asset);
            parameters.AddOptionalParameter("start_date", startTime?.ToString("yyyy-MM-dd"));
            parameters.AddOptionalParameter("end_date", endTime?.ToString("yyyy-MM-dd"));
            parameters.AddOptionalParameter("status", status == null ? null : JsonConvert.SerializeObject(status, new WithdrawStatusConverter(false)));
            parameters.AddOptionalParameter("page", page?.ToString());
            parameters.AddOptionalParameter("limit", pageSize?.ToString());
            parameters.AddOptionalParameter("recvWindow", receiveWindow?.ToString(CultureInfo.InvariantCulture) ?? _baseClient.ClientOptions.ReceiveWindow.TotalMilliseconds.ToString(CultureInfo.InvariantCulture));

            var result = await _baseClient.SendRequestAsync<BybitData<IEnumerable<BybitWithdrawal>>>(_baseClient.GetUrl("v2/private/wallet/withdraw/list"), HttpMethod.Get, ct, parameters, true).ConfigureAwait(false);
            if (!result)
                return result.As<IEnumerable<BybitWithdrawal>>(default);

            if (result.Data.Data == null)
                return result.As<IEnumerable<BybitWithdrawal>>(new BybitWithdrawal[0]);

            return result.As(result.Data.Data);
        }

        #endregion

        #region Get asset exchange history

        /// <inheritdoc />
        public async Task<WebCallResult<IEnumerable<BybitExchangeHistoryEntry>>> GetAssetExchangeHistoryAsync(long? fromId = null, SearchDirection? direction = null, int? limit = null, long? receiveWindow = null, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            parameters.AddOptionalParameter("from", fromId?.ToString());
            parameters.AddOptionalParameter("direction", direction == null ? null : JsonConvert.SerializeObject(direction, new SearchDirectionConverter(false)));
            parameters.AddOptionalParameter("limit", limit?.ToString());
            parameters.AddOptionalParameter("recvWindow", receiveWindow?.ToString(CultureInfo.InvariantCulture) ?? _baseClient.ClientOptions.ReceiveWindow.TotalMilliseconds.ToString(CultureInfo.InvariantCulture));

            return await _baseClient.SendRequestAsync<IEnumerable<BybitExchangeHistoryEntry>>(_baseClient.GetUrl("v2/private/exchange-order/list"), HttpMethod.Get, ct, parameters, true).ConfigureAwait(false);
        }

        #endregion

        #region Get asset exchange history

        /// <inheritdoc />
        public async Task<WebCallResult<IEnumerable<ByBitApiKeyInfo>>> GetApiKeyInfoAsync(long? receiveWindow = null, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            parameters.AddOptionalParameter("recvWindow", receiveWindow?.ToString(CultureInfo.InvariantCulture) ?? _baseClient.ClientOptions.ReceiveWindow.TotalMilliseconds.ToString(CultureInfo.InvariantCulture));

            return await _baseClient.SendRequestAsync<IEnumerable<ByBitApiKeyInfo>>(_baseClient.GetUrl("v2/private/account/api-key"), HttpMethod.Get, ct, parameters, true).ConfigureAwait(false);
        }

        #endregion
    }
}
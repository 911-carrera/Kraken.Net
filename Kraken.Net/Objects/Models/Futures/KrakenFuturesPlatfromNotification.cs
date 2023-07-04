﻿using CryptoExchange.Net.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Kraken.Net.Objects.Models.Futures
{
    /// <summary>
    /// Platform info
    /// </summary>
    public class KrakenFuturesPlatfromNotificationResult : KrakenFuturesResult
    {
        /// <summary>
        /// Notifications
        /// </summary>
        public IEnumerable<KrakenFuturesPlatfromNotification> Notifications { get; set; } = Array.Empty<KrakenFuturesPlatfromNotification>();
    }

    /// <summary>
    /// Platform notification info
    /// </summary>
    public class KrakenFuturesPlatfromNotification
    {
        /// <summary>
        /// The time that notification is taking effect.
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? EffectiveTime { get; set; }
        /// <summary>
        /// The notification note. A short description about the specific notification.
        /// </summary>
        public string? Note { get; set; }
        /// <summary>
        /// The notification priorities: low / medium / high. If priority == "high" then it implies downtime will occur at EffectiveTime when Type == "maintenance".
        /// </summary>
        public string Priority { get; set; } = string.Empty;
        /// <summary>
        /// If type == "maintenance" then it implies downtime will occur at EffectiveTime if Priority == "high".
        /// </summary>
        public string Type { get; set; } = string.Empty;
    }
}

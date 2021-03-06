// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Storage.Tables.Models
{
    /// <summary> Storage Service Properties. </summary>
    public partial class StorageServiceProperties
    {
        /// <summary> Azure Analytics Logging settings. </summary>
        public Logging Logging { get; set; }
        /// <summary> A summary of request statistics grouped by API in hourly aggregates for queues. </summary>
        public Metrics HourMetrics { get; set; }
        /// <summary> a summary of request statistics grouped by API in minute aggregates for queues. </summary>
        public Metrics MinuteMetrics { get; set; }
        /// <summary> The set of CORS rules. </summary>
        public IList<CorsRule> Cors { get; set; }
    }
}

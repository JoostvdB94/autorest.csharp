// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Management.Models
{
    /// <summary> An update history of the ImmutabilityPolicy of a blob container. </summary>
    public partial class UpdateHistoryProperty
    {
        /// <summary> The ImmutabilityPolicy update type of a blob container, possible values include: put, lock and extend. </summary>
        public ImmutabilityPolicyUpdateType? Update { get; internal set; }
        /// <summary> The immutability period for the blobs in the container since the policy creation, in days. </summary>
        public int? ImmutabilityPeriodSinceCreationInDays { get; internal set; }
        /// <summary> Returns the date and time the ImmutabilityPolicy was updated. </summary>
        public DateTimeOffset? Timestamp { get; internal set; }
        /// <summary> Returns the Object ID of the user who updated the ImmutabilityPolicy. </summary>
        public string ObjectIdentifier { get; internal set; }
        /// <summary> Returns the Tenant ID that issued the token for the user who updated the ImmutabilityPolicy. </summary>
        public string TenantId { get; internal set; }
        /// <summary> Returns the User Principal Name of the user who updated the ImmutabilityPolicy. </summary>
        public string Upn { get; internal set; }
    }
}

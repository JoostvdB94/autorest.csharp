// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace xml_service.Models
{
    /// <summary> An Access policy. </summary>
    public partial class AccessPolicy
    {
        /// <summary> the date-time the policy is active. </summary>
        public DateTimeOffset Start { get; set; }
        /// <summary> the date-time the policy expires. </summary>
        public DateTimeOffset Expiry { get; set; }
        /// <summary> the permissions for the acl policy. </summary>
        public string Permission { get; set; }
    }
}

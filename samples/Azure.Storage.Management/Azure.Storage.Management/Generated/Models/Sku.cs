// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Storage.Management.Models
{
    /// <summary> The SKU of the storage account. </summary>
    public partial class Sku
    {
        /// <summary> The SKU name. Required for account creation; optional for update. Note that in older versions, SKU name was called accountType. </summary>
        public SkuName Name { get; set; }
        /// <summary> The SKU tier. This is based on the SKU name. </summary>
        public SkuTier? Tier { get; set; }
    }
}

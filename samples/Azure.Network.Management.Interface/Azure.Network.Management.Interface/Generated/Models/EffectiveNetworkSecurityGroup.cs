// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Network.Management.Interface.Models
{
    /// <summary> Effective network security group. </summary>
    public partial class EffectiveNetworkSecurityGroup
    {
        /// <summary> The ID of network security group that is applied. </summary>
        public SubResource NetworkSecurityGroup { get; set; }
        /// <summary> Associated resources. </summary>
        public EffectiveNetworkSecurityGroupAssociation Association { get; set; }
        /// <summary> A collection of effective security rules. </summary>
        public IList<EffectiveNetworkSecurityRule> EffectiveSecurityRules { get; set; }
        /// <summary> Mapping of tags to list of IP Addresses included within the tag. </summary>
        public string TagMap { get; set; }
    }
}

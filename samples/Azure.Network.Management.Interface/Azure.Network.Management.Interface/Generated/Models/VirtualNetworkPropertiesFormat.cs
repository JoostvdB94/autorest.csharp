// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Network.Management.Interface.Models
{
    /// <summary> Properties of the virtual network. </summary>
    public partial class VirtualNetworkPropertiesFormat
    {
        /// <summary> The AddressSpace that contains an array of IP address ranges that can be used by subnets. </summary>
        public AddressSpace AddressSpace { get; set; }
        /// <summary> The dhcpOptions that contains an array of DNS servers available to VMs deployed in the virtual network. </summary>
        public DhcpOptions DhcpOptions { get; set; }
        /// <summary> A list of subnets in a Virtual Network. </summary>
        public IList<Subnet> Subnets { get; set; }
        /// <summary> A list of peerings in a Virtual Network. </summary>
        public IList<VirtualNetworkPeering> VirtualNetworkPeerings { get; set; }
        /// <summary> The resourceGuid property of the Virtual Network resource. </summary>
        public string ResourceGuid { get; internal set; }
        /// <summary> The provisioning state of the virtual network resource. </summary>
        public ProvisioningState? ProvisioningState { get; internal set; }
        /// <summary> Indicates if DDoS protection is enabled for all the protected resources in the virtual network. It requires a DDoS protection plan associated with the resource. </summary>
        public bool? EnableDdosProtection { get; set; }
        /// <summary> Indicates if VM protection is enabled for all the subnets in the virtual network. </summary>
        public bool? EnableVmProtection { get; set; }
        /// <summary> The DDoS protection plan associated with the virtual network. </summary>
        public SubResource DdosProtectionPlan { get; set; }
        /// <summary> Bgp Communities sent over ExpressRoute with each route corresponding to a prefix in this VNET. </summary>
        public VirtualNetworkBgpCommunities BgpCommunities { get; set; }
    }
}

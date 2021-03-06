// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Network.Management.Interface.Models
{
    /// <summary> Virtual Network Tap properties. </summary>
    public partial class VirtualNetworkTapPropertiesFormat
    {
        /// <summary> Specifies the list of resource IDs for the network interface IP configuration that needs to be tapped. </summary>
        public IList<NetworkInterfaceTapConfiguration> NetworkInterfaceTapConfigurations { get; internal set; }
        /// <summary> The resource GUID property of the virtual network tap resource. </summary>
        public string ResourceGuid { get; internal set; }
        /// <summary> The provisioning state of the virtual network tap resource. </summary>
        public ProvisioningState? ProvisioningState { get; internal set; }
        /// <summary> The reference to the private IP Address of the collector nic that will receive the tap. </summary>
        public NetworkInterfaceIPConfiguration DestinationNetworkInterfaceIPConfiguration { get; set; }
        /// <summary> The reference to the private IP address on the internal Load Balancer that will receive the tap. </summary>
        public FrontendIPConfiguration DestinationLoadBalancerFrontEndIPConfiguration { get; set; }
        /// <summary> The VXLAN destination port that will receive the tapped traffic. </summary>
        public int? DestinationPort { get; set; }
    }
}

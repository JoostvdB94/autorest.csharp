// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Network.Management.Interface.Models
{
    /// <summary> Properties of Virtual Network Tap configuration. </summary>
    public partial class NetworkInterfaceTapConfigurationPropertiesFormat
    {
        /// <summary> The reference to the Virtual Network Tap resource. </summary>
        public VirtualNetworkTap VirtualNetworkTap { get; set; }
        /// <summary> The provisioning state of the network interface tap configuration resource. </summary>
        public ProvisioningState? ProvisioningState { get; internal set; }
    }
}
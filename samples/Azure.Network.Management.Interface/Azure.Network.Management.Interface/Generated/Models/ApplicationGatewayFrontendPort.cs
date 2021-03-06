// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Network.Management.Interface.Models
{
    /// <summary> Frontend port of an application gateway. </summary>
    public partial class ApplicationGatewayFrontendPort : SubResource
    {
        /// <summary> Name of the frontend port that is unique within an Application Gateway. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; internal set; }
        /// <summary> Type of the resource. </summary>
        public string Type { get; internal set; }
        /// <summary> Frontend port. </summary>
        public int? Port { get; set; }
        /// <summary> The provisioning state of the frontend port resource. </summary>
        public ProvisioningState? ProvisioningState { get; internal set; }
    }
}

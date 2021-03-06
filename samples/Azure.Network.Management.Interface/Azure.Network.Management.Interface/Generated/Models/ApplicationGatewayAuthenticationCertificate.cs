// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Network.Management.Interface.Models
{
    /// <summary> Authentication certificates of an application gateway. </summary>
    public partial class ApplicationGatewayAuthenticationCertificate : SubResource
    {
        /// <summary> Name of the authentication certificate that is unique within an Application Gateway. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; internal set; }
        /// <summary> Type of the resource. </summary>
        public string Type { get; internal set; }
        /// <summary> Certificate public data. </summary>
        public string Data { get; set; }
        /// <summary> The provisioning state of the authentication certificate resource. </summary>
        public ProvisioningState? ProvisioningState { get; internal set; }
    }
}

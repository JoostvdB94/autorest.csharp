// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Network.Management.Interface.Models
{
    /// <summary> Inbound NAT pool of the load balancer. </summary>
    public partial class InboundNatPool : SubResource
    {
        /// <summary> The name of the resource that is unique within the set of inbound NAT pools used by the load balancer. This name can be used to access the resource. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; internal set; }
        /// <summary> Type of the resource. </summary>
        public string Type { get; internal set; }
        /// <summary> A reference to frontend IP addresses. </summary>
        public SubResource FrontendIPConfiguration { get; set; }
        /// <summary> The reference to the transport protocol used by the inbound NAT pool. </summary>
        public TransportProtocol? Protocol { get; set; }
        /// <summary> The first port number in the range of external ports that will be used to provide Inbound Nat to NICs associated with a load balancer. Acceptable values range between 1 and 65534. </summary>
        public int? FrontendPortRangeStart { get; set; }
        /// <summary> The last port number in the range of external ports that will be used to provide Inbound Nat to NICs associated with a load balancer. Acceptable values range between 1 and 65535. </summary>
        public int? FrontendPortRangeEnd { get; set; }
        /// <summary> The port used for internal connections on the endpoint. Acceptable values are between 1 and 65535. </summary>
        public int? BackendPort { get; set; }
        /// <summary> The timeout for the TCP idle connection. The value can be set between 4 and 30 minutes. The default value is 4 minutes. This element is only used when the protocol is set to TCP. </summary>
        public int? IdleTimeoutInMinutes { get; set; }
        /// <summary> Configures a virtual machine&apos;s endpoint for the floating IP capability required to configure a SQL AlwaysOn Availability Group. This setting is required when using the SQL AlwaysOn Availability Groups in SQL server. This setting can&apos;t be changed after you create the endpoint. </summary>
        public bool? EnableFloatingIP { get; set; }
        /// <summary> Receive bidirectional TCP Reset on TCP flow idle timeout or unexpected connection termination. This element is only used when the protocol is set to TCP. </summary>
        public bool? EnableTcpReset { get; set; }
        /// <summary> The provisioning state of the inbound NAT pool resource. </summary>
        public ProvisioningState? ProvisioningState { get; internal set; }
    }
}

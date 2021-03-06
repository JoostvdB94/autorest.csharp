// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Network.Management.Interface.Models
{
    /// <summary> Properties of the load balancer. </summary>
    public partial class LoadBalancerPropertiesFormat
    {
        /// <summary> Object representing the frontend IPs to be used for the load balancer. </summary>
        public IList<FrontendIPConfiguration> FrontendIPConfigurations { get; set; }
        /// <summary> Collection of backend address pools used by a load balancer. </summary>
        public IList<BackendAddressPool> BackendAddressPools { get; set; }
        /// <summary> Object collection representing the load balancing rules Gets the provisioning. </summary>
        public IList<LoadBalancingRule> LoadBalancingRules { get; set; }
        /// <summary> Collection of probe objects used in the load balancer. </summary>
        public IList<Probe> Probes { get; set; }
        /// <summary> Collection of inbound NAT Rules used by a load balancer. Defining inbound NAT rules on your load balancer is mutually exclusive with defining an inbound NAT pool. Inbound NAT pools are referenced from virtual machine scale sets. NICs that are associated with individual virtual machines cannot reference an Inbound NAT pool. They have to reference individual inbound NAT rules. </summary>
        public IList<InboundNatRule> InboundNatRules { get; set; }
        /// <summary> Defines an external port range for inbound NAT to a single backend port on NICs associated with a load balancer. Inbound NAT rules are created automatically for each NIC associated with the Load Balancer using an external port from this range. Defining an Inbound NAT pool on your Load Balancer is mutually exclusive with defining inbound Nat rules. Inbound NAT pools are referenced from virtual machine scale sets. NICs that are associated with individual virtual machines cannot reference an inbound NAT pool. They have to reference individual inbound NAT rules. </summary>
        public IList<InboundNatPool> InboundNatPools { get; set; }
        /// <summary> The outbound rules. </summary>
        public IList<OutboundRule> OutboundRules { get; set; }
        /// <summary> The resource GUID property of the load balancer resource. </summary>
        public string ResourceGuid { get; internal set; }
        /// <summary> The provisioning state of the load balancer resource. </summary>
        public ProvisioningState? ProvisioningState { get; internal set; }
    }
}

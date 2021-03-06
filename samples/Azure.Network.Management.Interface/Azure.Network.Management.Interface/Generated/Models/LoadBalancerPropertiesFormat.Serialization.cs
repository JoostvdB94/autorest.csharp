// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Network.Management.Interface.Models
{
    public partial class LoadBalancerPropertiesFormat : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (FrontendIPConfigurations != null)
            {
                writer.WritePropertyName("frontendIPConfigurations");
                writer.WriteStartArray();
                foreach (var item in FrontendIPConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (BackendAddressPools != null)
            {
                writer.WritePropertyName("backendAddressPools");
                writer.WriteStartArray();
                foreach (var item in BackendAddressPools)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (LoadBalancingRules != null)
            {
                writer.WritePropertyName("loadBalancingRules");
                writer.WriteStartArray();
                foreach (var item in LoadBalancingRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Probes != null)
            {
                writer.WritePropertyName("probes");
                writer.WriteStartArray();
                foreach (var item in Probes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (InboundNatRules != null)
            {
                writer.WritePropertyName("inboundNatRules");
                writer.WriteStartArray();
                foreach (var item in InboundNatRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (InboundNatPools != null)
            {
                writer.WritePropertyName("inboundNatPools");
                writer.WriteStartArray();
                foreach (var item in InboundNatPools)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (OutboundRules != null)
            {
                writer.WritePropertyName("outboundRules");
                writer.WriteStartArray();
                foreach (var item in OutboundRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (ResourceGuid != null)
            {
                writer.WritePropertyName("resourceGuid");
                writer.WriteStringValue(ResourceGuid);
            }
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
        }
        internal static LoadBalancerPropertiesFormat DeserializeLoadBalancerPropertiesFormat(JsonElement element)
        {
            LoadBalancerPropertiesFormat result = new LoadBalancerPropertiesFormat();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("frontendIPConfigurations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.FrontendIPConfigurations = new List<FrontendIPConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.FrontendIPConfigurations.Add(FrontendIPConfiguration.DeserializeFrontendIPConfiguration(item));
                    }
                    continue;
                }
                if (property.NameEquals("backendAddressPools"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.BackendAddressPools = new List<BackendAddressPool>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.BackendAddressPools.Add(BackendAddressPool.DeserializeBackendAddressPool(item));
                    }
                    continue;
                }
                if (property.NameEquals("loadBalancingRules"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.LoadBalancingRules = new List<LoadBalancingRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.LoadBalancingRules.Add(LoadBalancingRule.DeserializeLoadBalancingRule(item));
                    }
                    continue;
                }
                if (property.NameEquals("probes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Probes = new List<Probe>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Probes.Add(Probe.DeserializeProbe(item));
                    }
                    continue;
                }
                if (property.NameEquals("inboundNatRules"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.InboundNatRules = new List<InboundNatRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.InboundNatRules.Add(InboundNatRule.DeserializeInboundNatRule(item));
                    }
                    continue;
                }
                if (property.NameEquals("inboundNatPools"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.InboundNatPools = new List<InboundNatPool>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.InboundNatPools.Add(InboundNatPool.DeserializeInboundNatPool(item));
                    }
                    continue;
                }
                if (property.NameEquals("outboundRules"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.OutboundRules = new List<OutboundRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.OutboundRules.Add(OutboundRule.DeserializeOutboundRule(item));
                    }
                    continue;
                }
                if (property.NameEquals("resourceGuid"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.ResourceGuid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.ProvisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
            }
            return result;
        }
    }
}

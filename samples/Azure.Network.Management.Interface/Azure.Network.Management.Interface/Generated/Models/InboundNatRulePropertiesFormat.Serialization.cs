// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Network.Management.Interface.Models
{
    public partial class InboundNatRulePropertiesFormat : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (FrontendIPConfiguration != null)
            {
                writer.WritePropertyName("frontendIPConfiguration");
                writer.WriteObjectValue(FrontendIPConfiguration);
            }
            if (BackendIPConfiguration != null)
            {
                writer.WritePropertyName("backendIPConfiguration");
                writer.WriteObjectValue(BackendIPConfiguration);
            }
            if (Protocol != null)
            {
                writer.WritePropertyName("protocol");
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            if (FrontendPort != null)
            {
                writer.WritePropertyName("frontendPort");
                writer.WriteNumberValue(FrontendPort.Value);
            }
            if (BackendPort != null)
            {
                writer.WritePropertyName("backendPort");
                writer.WriteNumberValue(BackendPort.Value);
            }
            if (IdleTimeoutInMinutes != null)
            {
                writer.WritePropertyName("idleTimeoutInMinutes");
                writer.WriteNumberValue(IdleTimeoutInMinutes.Value);
            }
            if (EnableFloatingIP != null)
            {
                writer.WritePropertyName("enableFloatingIP");
                writer.WriteBooleanValue(EnableFloatingIP.Value);
            }
            if (EnableTcpReset != null)
            {
                writer.WritePropertyName("enableTcpReset");
                writer.WriteBooleanValue(EnableTcpReset.Value);
            }
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
        }
        internal static InboundNatRulePropertiesFormat DeserializeInboundNatRulePropertiesFormat(JsonElement element)
        {
            InboundNatRulePropertiesFormat result = new InboundNatRulePropertiesFormat();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("frontendIPConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.FrontendIPConfiguration = SubResource.DeserializeSubResource(property.Value);
                    continue;
                }
                if (property.NameEquals("backendIPConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.BackendIPConfiguration = NetworkInterfaceIPConfiguration.DeserializeNetworkInterfaceIPConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("protocol"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Protocol = new TransportProtocol(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("frontendPort"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.FrontendPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("backendPort"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.BackendPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("idleTimeoutInMinutes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.IdleTimeoutInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("enableFloatingIP"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.EnableFloatingIP = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableTcpReset"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.EnableTcpReset = property.Value.GetBoolean();
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

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Network.Management.Interface.Models
{
    public partial class VirtualNetworkPeering : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Etag != null)
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            if (Id != null)
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (AllowVirtualNetworkAccess != null)
            {
                writer.WritePropertyName("allowVirtualNetworkAccess");
                writer.WriteBooleanValue(AllowVirtualNetworkAccess.Value);
            }
            if (AllowForwardedTraffic != null)
            {
                writer.WritePropertyName("allowForwardedTraffic");
                writer.WriteBooleanValue(AllowForwardedTraffic.Value);
            }
            if (AllowGatewayTransit != null)
            {
                writer.WritePropertyName("allowGatewayTransit");
                writer.WriteBooleanValue(AllowGatewayTransit.Value);
            }
            if (UseRemoteGateways != null)
            {
                writer.WritePropertyName("useRemoteGateways");
                writer.WriteBooleanValue(UseRemoteGateways.Value);
            }
            if (RemoteVirtualNetwork != null)
            {
                writer.WritePropertyName("remoteVirtualNetwork");
                writer.WriteObjectValue(RemoteVirtualNetwork);
            }
            if (RemoteAddressSpace != null)
            {
                writer.WritePropertyName("remoteAddressSpace");
                writer.WriteObjectValue(RemoteAddressSpace);
            }
            if (PeeringState != null)
            {
                writer.WritePropertyName("peeringState");
                writer.WriteStringValue(PeeringState.Value.ToString());
            }
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
        internal static VirtualNetworkPeering DeserializeVirtualNetworkPeering(JsonElement element)
        {
            VirtualNetworkPeering result = new VirtualNetworkPeering();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("allowVirtualNetworkAccess"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.AllowVirtualNetworkAccess = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("allowForwardedTraffic"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.AllowForwardedTraffic = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("allowGatewayTransit"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.AllowGatewayTransit = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("useRemoteGateways"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.UseRemoteGateways = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("remoteVirtualNetwork"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.RemoteVirtualNetwork = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("remoteAddressSpace"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.RemoteAddressSpace = AddressSpace.DeserializeAddressSpace(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("peeringState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.PeeringState = new VirtualNetworkPeeringState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.ProvisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return result;
        }
    }
}

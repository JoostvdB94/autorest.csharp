// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Network.Management.Interface.Models
{
    public partial class PublicIPAddressPropertiesFormat : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (PublicIPAllocationMethod != null)
            {
                writer.WritePropertyName("publicIPAllocationMethod");
                writer.WriteStringValue(PublicIPAllocationMethod.Value.ToString());
            }
            if (PublicIPAddressVersion != null)
            {
                writer.WritePropertyName("publicIPAddressVersion");
                writer.WriteStringValue(PublicIPAddressVersion.Value.ToString());
            }
            if (IpConfiguration != null)
            {
                writer.WritePropertyName("ipConfiguration");
                writer.WriteObjectValue(IpConfiguration);
            }
            if (DnsSettings != null)
            {
                writer.WritePropertyName("dnsSettings");
                writer.WriteObjectValue(DnsSettings);
            }
            if (DdosSettings != null)
            {
                writer.WritePropertyName("ddosSettings");
                writer.WriteObjectValue(DdosSettings);
            }
            if (IpTags != null)
            {
                writer.WritePropertyName("ipTags");
                writer.WriteStartArray();
                foreach (var item in IpTags)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (IpAddress != null)
            {
                writer.WritePropertyName("ipAddress");
                writer.WriteStringValue(IpAddress);
            }
            if (PublicIPPrefix != null)
            {
                writer.WritePropertyName("publicIPPrefix");
                writer.WriteObjectValue(PublicIPPrefix);
            }
            if (IdleTimeoutInMinutes != null)
            {
                writer.WritePropertyName("idleTimeoutInMinutes");
                writer.WriteNumberValue(IdleTimeoutInMinutes.Value);
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
        internal static PublicIPAddressPropertiesFormat DeserializePublicIPAddressPropertiesFormat(JsonElement element)
        {
            PublicIPAddressPropertiesFormat result = new PublicIPAddressPropertiesFormat();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publicIPAllocationMethod"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.PublicIPAllocationMethod = new IPAllocationMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publicIPAddressVersion"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.PublicIPAddressVersion = new IPVersion(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.IpConfiguration = IPConfiguration.DeserializeIPConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("dnsSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.DnsSettings = PublicIPAddressDnsSettings.DeserializePublicIPAddressDnsSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("ddosSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.DdosSettings = DdosSettings.DeserializeDdosSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("ipTags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.IpTags = new List<IpTag>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.IpTags.Add(IpTag.DeserializeIpTag(item));
                    }
                    continue;
                }
                if (property.NameEquals("ipAddress"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.IpAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publicIPPrefix"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.PublicIPPrefix = SubResource.DeserializeSubResource(property.Value);
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

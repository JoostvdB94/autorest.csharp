// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Network.Management.Interface.Models
{
    public partial class ApplicationGatewayHttpListener : IUtf8JsonSerializable
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
            if (Type != null)
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            if (Id != null)
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (FrontendIPConfiguration != null)
            {
                writer.WritePropertyName("frontendIPConfiguration");
                writer.WriteObjectValue(FrontendIPConfiguration);
            }
            if (FrontendPort != null)
            {
                writer.WritePropertyName("frontendPort");
                writer.WriteObjectValue(FrontendPort);
            }
            if (Protocol != null)
            {
                writer.WritePropertyName("protocol");
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            if (HostName != null)
            {
                writer.WritePropertyName("hostName");
                writer.WriteStringValue(HostName);
            }
            if (SslCertificate != null)
            {
                writer.WritePropertyName("sslCertificate");
                writer.WriteObjectValue(SslCertificate);
            }
            if (RequireServerNameIndication != null)
            {
                writer.WritePropertyName("requireServerNameIndication");
                writer.WriteBooleanValue(RequireServerNameIndication.Value);
            }
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (CustomErrorConfigurations != null)
            {
                writer.WritePropertyName("customErrorConfigurations");
                writer.WriteStartArray();
                foreach (var item in CustomErrorConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (FirewallPolicy != null)
            {
                writer.WritePropertyName("firewallPolicy");
                writer.WriteObjectValue(FirewallPolicy);
            }
            if (Hostnames != null)
            {
                writer.WritePropertyName("hostnames");
                writer.WriteStartArray();
                foreach (var item in Hostnames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
        internal static ApplicationGatewayHttpListener DeserializeApplicationGatewayHttpListener(JsonElement element)
        {
            ApplicationGatewayHttpListener result = new ApplicationGatewayHttpListener();
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
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Type = property.Value.GetString();
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
                        if (property0.NameEquals("frontendIPConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.FrontendIPConfiguration = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("frontendPort"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.FrontendPort = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("protocol"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.Protocol = new ApplicationGatewayProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("hostName"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.HostName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sslCertificate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.SslCertificate = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("requireServerNameIndication"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.RequireServerNameIndication = property0.Value.GetBoolean();
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
                        if (property0.NameEquals("customErrorConfigurations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.CustomErrorConfigurations = new List<ApplicationGatewayCustomError>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                result.CustomErrorConfigurations.Add(ApplicationGatewayCustomError.DeserializeApplicationGatewayCustomError(item));
                            }
                            continue;
                        }
                        if (property0.NameEquals("firewallPolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.FirewallPolicy = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("hostnames"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.Hostnames = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                result.Hostnames.Add(item.GetString());
                            }
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

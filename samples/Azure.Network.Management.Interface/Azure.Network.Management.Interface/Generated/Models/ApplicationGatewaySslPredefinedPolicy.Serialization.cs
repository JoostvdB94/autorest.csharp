// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Network.Management.Interface.Models
{
    public partial class ApplicationGatewaySslPredefinedPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Id != null)
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (CipherSuites != null)
            {
                writer.WritePropertyName("cipherSuites");
                writer.WriteStartArray();
                foreach (var item in CipherSuites)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (MinProtocolVersion != null)
            {
                writer.WritePropertyName("minProtocolVersion");
                writer.WriteStringValue(MinProtocolVersion.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
        internal static ApplicationGatewaySslPredefinedPolicy DeserializeApplicationGatewaySslPredefinedPolicy(JsonElement element)
        {
            ApplicationGatewaySslPredefinedPolicy result = new ApplicationGatewaySslPredefinedPolicy();
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
                        if (property0.NameEquals("cipherSuites"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.CipherSuites = new List<ApplicationGatewaySslCipherSuite>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                result.CipherSuites.Add(new ApplicationGatewaySslCipherSuite(item.GetString()));
                            }
                            continue;
                        }
                        if (property0.NameEquals("minProtocolVersion"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.MinProtocolVersion = new ApplicationGatewaySslProtocol(property0.Value.GetString());
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

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Network.Management.Interface.Models
{
    public partial class ApplicationGatewayFirewallRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("ruleId");
            writer.WriteNumberValue(RuleId);
            if (Description != null)
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            writer.WriteEndObject();
        }
        internal static ApplicationGatewayFirewallRule DeserializeApplicationGatewayFirewallRule(JsonElement element)
        {
            ApplicationGatewayFirewallRule result = new ApplicationGatewayFirewallRule();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ruleId"))
                {
                    result.RuleId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Description = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}

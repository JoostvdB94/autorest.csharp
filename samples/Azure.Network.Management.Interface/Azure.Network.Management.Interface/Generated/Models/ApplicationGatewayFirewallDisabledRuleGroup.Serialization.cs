// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Network.Management.Interface.Models
{
    public partial class ApplicationGatewayFirewallDisabledRuleGroup : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("ruleGroupName");
            writer.WriteStringValue(RuleGroupName);
            if (Rules != null)
            {
                writer.WritePropertyName("rules");
                writer.WriteStartArray();
                foreach (var item in Rules)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
        internal static ApplicationGatewayFirewallDisabledRuleGroup DeserializeApplicationGatewayFirewallDisabledRuleGroup(JsonElement element)
        {
            ApplicationGatewayFirewallDisabledRuleGroup result = new ApplicationGatewayFirewallDisabledRuleGroup();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ruleGroupName"))
                {
                    result.RuleGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rules"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Rules = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Rules.Add(item.GetInt32());
                    }
                    continue;
                }
            }
            return result;
        }
    }
}

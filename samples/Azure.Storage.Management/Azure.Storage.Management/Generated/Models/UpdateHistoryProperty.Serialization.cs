// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Storage.Management.Models
{
    public partial class UpdateHistoryProperty : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Update != null)
            {
                writer.WritePropertyName("update");
                writer.WriteStringValue(Update.Value.ToString());
            }
            if (ImmutabilityPeriodSinceCreationInDays != null)
            {
                writer.WritePropertyName("immutabilityPeriodSinceCreationInDays");
                writer.WriteNumberValue(ImmutabilityPeriodSinceCreationInDays.Value);
            }
            if (Timestamp != null)
            {
                writer.WritePropertyName("timestamp");
                writer.WriteStringValue(Timestamp.Value, "S");
            }
            if (ObjectIdentifier != null)
            {
                writer.WritePropertyName("objectIdentifier");
                writer.WriteStringValue(ObjectIdentifier);
            }
            if (TenantId != null)
            {
                writer.WritePropertyName("tenantId");
                writer.WriteStringValue(TenantId);
            }
            if (Upn != null)
            {
                writer.WritePropertyName("upn");
                writer.WriteStringValue(Upn);
            }
            writer.WriteEndObject();
        }
        internal static UpdateHistoryProperty DeserializeUpdateHistoryProperty(JsonElement element)
        {
            UpdateHistoryProperty result = new UpdateHistoryProperty();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("update"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Update = new ImmutabilityPolicyUpdateType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("immutabilityPeriodSinceCreationInDays"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.ImmutabilityPeriodSinceCreationInDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("timestamp"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Timestamp = property.Value.GetDateTimeOffset("S");
                    continue;
                }
                if (property.NameEquals("objectIdentifier"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.ObjectIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tenantId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.TenantId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("upn"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Upn = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}

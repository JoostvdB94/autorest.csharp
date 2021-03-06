// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Storage.Management.Models
{
    public partial class EncryptionScopeProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Source != null)
            {
                writer.WritePropertyName("source");
                writer.WriteStringValue(Source.Value.ToString());
            }
            if (State != null)
            {
                writer.WritePropertyName("state");
                writer.WriteStringValue(State.Value.ToString());
            }
            if (CreationTime != null)
            {
                writer.WritePropertyName("creationTime");
                writer.WriteStringValue(CreationTime.Value, "S");
            }
            if (LastModifiedTime != null)
            {
                writer.WritePropertyName("lastModifiedTime");
                writer.WriteStringValue(LastModifiedTime.Value, "S");
            }
            if (KeyVaultProperties != null)
            {
                writer.WritePropertyName("keyVaultProperties");
                writer.WriteObjectValue(KeyVaultProperties);
            }
            writer.WriteEndObject();
        }
        internal static EncryptionScopeProperties DeserializeEncryptionScopeProperties(JsonElement element)
        {
            EncryptionScopeProperties result = new EncryptionScopeProperties();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("source"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Source = new EncryptionScopeSource(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("state"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.State = new EncryptionScopeState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("creationTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.CreationTime = property.Value.GetDateTimeOffset("S");
                    continue;
                }
                if (property.NameEquals("lastModifiedTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.LastModifiedTime = property.Value.GetDateTimeOffset("S");
                    continue;
                }
                if (property.NameEquals("keyVaultProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.KeyVaultProperties = EncryptionScopeKeyVaultProperties.DeserializeEncryptionScopeKeyVaultProperties(property.Value);
                    continue;
                }
            }
            return result;
        }
    }
}

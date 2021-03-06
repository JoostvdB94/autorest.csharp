// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Storage.Management.Models
{
    public partial class AzureFilesIdentityBasedAuthentication : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("directoryServiceOptions");
            writer.WriteStringValue(DirectoryServiceOptions.ToString());
            if (ActiveDirectoryProperties != null)
            {
                writer.WritePropertyName("activeDirectoryProperties");
                writer.WriteObjectValue(ActiveDirectoryProperties);
            }
            writer.WriteEndObject();
        }
        internal static AzureFilesIdentityBasedAuthentication DeserializeAzureFilesIdentityBasedAuthentication(JsonElement element)
        {
            AzureFilesIdentityBasedAuthentication result = new AzureFilesIdentityBasedAuthentication();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("directoryServiceOptions"))
                {
                    result.DirectoryServiceOptions = new DirectoryServiceOptions(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("activeDirectoryProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.ActiveDirectoryProperties = ActiveDirectoryProperties.DeserializeActiveDirectoryProperties(property.Value);
                    continue;
                }
            }
            return result;
        }
    }
}

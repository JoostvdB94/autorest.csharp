// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    public partial class PageResult : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("page");
            writer.WriteNumberValue(Page);
            if (ClusterId != null)
            {
                writer.WritePropertyName("clusterId");
                writer.WriteNumberValue(ClusterId.Value);
            }
            if (KeyValuePairs != null)
            {
                writer.WritePropertyName("keyValuePairs");
                writer.WriteStartArray();
                foreach (var item in KeyValuePairs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Tables != null)
            {
                writer.WritePropertyName("tables");
                writer.WriteStartArray();
                foreach (var item in Tables)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
        internal static PageResult DeserializePageResult(JsonElement element)
        {
            PageResult result = new PageResult();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("page"))
                {
                    result.Page = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("clusterId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.ClusterId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("keyValuePairs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.KeyValuePairs = new List<KeyValuePair>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.KeyValuePairs.Add(KeyValuePair.DeserializeKeyValuePair(item));
                    }
                    continue;
                }
                if (property.NameEquals("tables"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Tables = new List<DataTable>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Tables.Add(DataTable.DeserializeDataTable(item));
                    }
                    continue;
                }
            }
            return result;
        }
    }
}

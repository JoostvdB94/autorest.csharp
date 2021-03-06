// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    public partial class DocumentResult : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("docType");
            writer.WriteStringValue(DocType);
            writer.WritePropertyName("pageRange");
            writer.WriteStartArray();
            foreach (var item in PageRange)
            {
                writer.WriteNumberValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("fields");
            writer.WriteStartObject();
            foreach (var item0 in Fields)
            {
                writer.WritePropertyName(item0.Key);
                writer.WriteObjectValue(item0.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
        internal static DocumentResult DeserializeDocumentResult(JsonElement element)
        {
            DocumentResult result = new DocumentResult();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("docType"))
                {
                    result.DocType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pageRange"))
                {
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.PageRange.Add(item.GetInt32());
                    }
                    continue;
                }
                if (property.NameEquals("fields"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        result.Fields.Add(property0.Name, FieldValue.DeserializeFieldValue(property0.Value));
                    }
                    continue;
                }
            }
            return result;
        }
    }
}

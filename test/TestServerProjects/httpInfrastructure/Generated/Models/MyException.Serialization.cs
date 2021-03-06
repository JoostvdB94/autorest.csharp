// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace httpInfrastructure.Models
{
    public partial class MyException : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (StatusCode != null)
            {
                writer.WritePropertyName("statusCode");
                writer.WriteStringValue(StatusCode);
            }
            writer.WriteEndObject();
        }
        internal static MyException DeserializeMyException(JsonElement element)
        {
            MyException result = new MyException();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("statusCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.StatusCode = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}

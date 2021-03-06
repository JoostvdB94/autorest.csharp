// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class ScoringProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (TextWeights != null)
            {
                writer.WritePropertyName("text");
                writer.WriteObjectValue(TextWeights);
            }
            if (Functions != null)
            {
                writer.WritePropertyName("functions");
                writer.WriteStartArray();
                foreach (var item in Functions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (FunctionAggregation != null)
            {
                writer.WritePropertyName("functionAggregation");
                writer.WriteStringValue(FunctionAggregation.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }
        internal static ScoringProfile DeserializeScoringProfile(JsonElement element)
        {
            ScoringProfile result = new ScoringProfile();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    result.Name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("text"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.TextWeights = TextWeights.DeserializeTextWeights(property.Value);
                    continue;
                }
                if (property.NameEquals("functions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Functions = new List<ScoringFunction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Functions.Add(ScoringFunction.DeserializeScoringFunction(item));
                    }
                    continue;
                }
                if (property.NameEquals("functionAggregation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.FunctionAggregation = property.Value.GetString().ToScoringFunctionAggregation();
                    continue;
                }
            }
            return result;
        }
    }
}

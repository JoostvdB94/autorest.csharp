// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace CognitiveServices.TextAnalytics.Models
{
    internal static class DocumentSentimentValueExtensions
    {
        public static string ToSerialString(this DocumentSentimentValue value) => value switch
        {
            DocumentSentimentValue.Positive => "positive",
            DocumentSentimentValue.Neutral => "neutral",
            DocumentSentimentValue.Negative => "negative",
            DocumentSentimentValue.Mixed => "mixed",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DocumentSentimentValue value.")
        };

        public static DocumentSentimentValue ToDocumentSentimentValue(this string value) => value switch
        {
            "positive" => DocumentSentimentValue.Positive,
            "neutral" => DocumentSentimentValue.Neutral,
            "negative" => DocumentSentimentValue.Negative,
            "mixed" => DocumentSentimentValue.Mixed,
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DocumentSentimentValue value.")
        };
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace CognitiveServices.TextAnalytics.Models
{
    /// <summary> The DocumentError. </summary>
    public partial class DocumentError
    {
        /// <summary> Document Id. </summary>
        public string Id { get; set; }
        /// <summary> Document Error. </summary>
        public TextAnalyticsError Error { get; set; } = new TextAnalyticsError();
    }
}

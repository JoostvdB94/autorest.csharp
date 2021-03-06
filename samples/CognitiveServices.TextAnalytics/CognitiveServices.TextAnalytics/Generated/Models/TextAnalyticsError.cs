// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace CognitiveServices.TextAnalytics.Models
{
    /// <summary> The TextAnalyticsError. </summary>
    public partial class TextAnalyticsError
    {
        /// <summary> Error code. </summary>
        public ErrorCodeValue Code { get; set; }
        /// <summary> Error message. </summary>
        public string Message { get; set; }
        /// <summary> Error target. </summary>
        public string Target { get; set; }
        /// <summary> Inner error contains more specific information. </summary>
        public InnerError InnerError { get; set; }
        /// <summary> Details about specific errors that led to this reported error. </summary>
        public IList<TextAnalyticsError> Details { get; set; }
    }
}

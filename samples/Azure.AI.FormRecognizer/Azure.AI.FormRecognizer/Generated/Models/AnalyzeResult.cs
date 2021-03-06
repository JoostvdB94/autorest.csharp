// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Analyze operation result. </summary>
    public partial class AnalyzeResult
    {
        /// <summary> Version of schema used for this result. </summary>
        public string Version { get; set; }
        /// <summary> Text extracted from the input. </summary>
        public IList<ReadResult> ReadResults { get; set; } = new List<ReadResult>();
        /// <summary> Page-level information extracted from the input. </summary>
        public IList<PageResult> PageResults { get; set; }
        /// <summary> Document-level information extracted from the input. </summary>
        public IList<DocumentResult> DocumentResults { get; set; }
        /// <summary> List of errors reported during the analyze operation. </summary>
        public IList<ErrorInformation> Errors { get; set; }
    }
}

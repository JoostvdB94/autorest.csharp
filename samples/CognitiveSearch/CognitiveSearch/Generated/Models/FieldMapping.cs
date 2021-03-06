// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace CognitiveSearch.Models
{
    /// <summary> Defines a mapping between a field in a data source and a target field in an index. </summary>
    public partial class FieldMapping
    {
        /// <summary> The name of the field in the data source. </summary>
        public string SourceFieldName { get; set; }
        /// <summary> The name of the target field in the index. Same as the source field name by default. </summary>
        public string TargetFieldName { get; set; }
        /// <summary> A function to apply to each source field value before indexing. </summary>
        public FieldMappingFunction MappingFunction { get; set; }
    }
}

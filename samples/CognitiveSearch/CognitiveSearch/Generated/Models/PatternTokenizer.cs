// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace CognitiveSearch.Models
{
    /// <summary> Tokenizer that uses regex pattern matching to construct distinct tokens. This tokenizer is implemented using Apache Lucene. </summary>
    public partial class PatternTokenizer : Tokenizer
    {
        /// <summary> Initializes a new instance of PatternTokenizer. </summary>
        public PatternTokenizer()
        {
            OdataType = "#Microsoft.Azure.Search.PatternTokenizer";
        }
        /// <summary> A regular expression pattern to match token separators. Default is an expression that matches one or more whitespace characters. </summary>
        public string Pattern { get; set; }
        /// <summary> Regular expression flags. </summary>
        public RegexFlags? Flags { get; set; }
        /// <summary> The zero-based ordinal of the matching group in the regular expression pattern to extract into tokens. Use -1 if you want to use the entire pattern to split the input into tokens, irrespective of matching groups. Default is -1. </summary>
        public int? Group { get; set; }
    }
}

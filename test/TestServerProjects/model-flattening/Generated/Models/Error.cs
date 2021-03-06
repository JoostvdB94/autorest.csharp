// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace model_flattening.Models
{
    /// <summary> The Error. </summary>
    public partial class Error
    {
        public int? Status { get; set; }
        public string Message { get; set; }
        public Error ParentError { get; set; }
    }
}

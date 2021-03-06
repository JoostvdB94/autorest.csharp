// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Information about the extracted table contained in a page. </summary>
    public partial class DataTable
    {
        /// <summary> Number of rows. </summary>
        public int Rows { get; set; }
        /// <summary> Number of columns. </summary>
        public int Columns { get; set; }
        /// <summary> List of cells contained in the table. </summary>
        public IList<DataTableCell> Cells { get; set; } = new List<DataTableCell>();
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Text extracted from a page in the input document. </summary>
    public partial class ReadResult
    {
        /// <summary> The 1-based page number in the input document. </summary>
        public int Page { get; set; }
        /// <summary> The general orientation of the text in clockwise direction, measured in degrees between (-180, 180]. </summary>
        public float Angle { get; set; }
        /// <summary> The width of the image/PDF in pixels/inches, respectively. </summary>
        public float Width { get; set; }
        /// <summary> The height of the image/PDF in pixels/inches, respectively. </summary>
        public float Height { get; set; }
        /// <summary> The unit used by the width, height and boundingBox properties. For images, the unit is &quot;pixel&quot;. For PDF, the unit is &quot;inch&quot;. </summary>
        public LengthUnit Unit { get; set; }
        /// <summary> The detected language on the page overall. </summary>
        public Language? Language { get; set; }
        /// <summary> When includeTextDetails is set to true, a list of recognized text lines. The maximum number of lines returned is 300 per page. The lines are sorted top to bottom, left to right, although in certain cases proximity is treated with higher priority. As the sorting order depends on the detected text, it may change across images and OCR version updates. Thus, business logic should be built upon the actual line location instead of order. </summary>
        public IList<TextLine> Lines { get; set; }
    }
}

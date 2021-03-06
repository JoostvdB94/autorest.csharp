// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Xml;
using System.Xml.Linq;
using Azure.Core;

namespace xml_service.Models
{
    public partial class RootWithRefAndMeta : IXmlSerializable
    {
        void IXmlSerializable.Write(XmlWriter writer, string nameHint)
        {
            writer.WriteStartElement(nameHint ?? "RootWithRefAndMeta");
            if (RefToModel != null)
            {
                writer.WriteObjectValue(RefToModel, "XMLComplexTypeWithMeta");
            }
            if (Something != null)
            {
                writer.WriteStartElement("Something");
                writer.WriteValue(Something);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }
        internal static RootWithRefAndMeta DeserializeRootWithRefAndMeta(XElement element)
        {
            RootWithRefAndMeta result = default;
            result = new RootWithRefAndMeta(); ComplexTypeWithMeta value = default;
            var xMLComplexTypeWithMeta = element.Element("XMLComplexTypeWithMeta");
            if (xMLComplexTypeWithMeta != null)
            {
                value = ComplexTypeWithMeta.DeserializeComplexTypeWithMeta(xMLComplexTypeWithMeta);
            }
            result.RefToModel = value;
            string value0 = default;
            var something = element.Element("Something");
            if (something != null)
            {
                value0 = (string)something;
            }
            result.Something = value0;
            return result;
        }
    }
}

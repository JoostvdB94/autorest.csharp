// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Xml;
using System.Xml.Linq;
using Azure.Core;

namespace Azure.Storage.Tables.Models
{
    public partial class Logging : IXmlSerializable
    {
        void IXmlSerializable.Write(XmlWriter writer, string nameHint)
        {
            writer.WriteStartElement(nameHint ?? "Logging");
            writer.WriteStartElement("Version");
            writer.WriteValue(Version);
            writer.WriteEndElement();
            writer.WriteStartElement("Delete");
            writer.WriteValue(Delete);
            writer.WriteEndElement();
            writer.WriteStartElement("Read");
            writer.WriteValue(Read);
            writer.WriteEndElement();
            writer.WriteStartElement("Write");
            writer.WriteValue(Write);
            writer.WriteEndElement();
            writer.WriteObjectValue(RetentionPolicy, "RetentionPolicy");
            writer.WriteEndElement();
        }
        internal static Logging DeserializeLogging(XElement element)
        {
            Logging result = default;
            result = new Logging(); string value = default;
            var version = element.Element("Version");
            if (version != null)
            {
                value = (string)version;
            }
            result.Version = value;
            bool value0 = default;
            var delete = element.Element("Delete");
            if (delete != null)
            {
                value0 = (bool)delete;
            }
            result.Delete = value0;
            bool value1 = default;
            var read = element.Element("Read");
            if (read != null)
            {
                value1 = (bool)read;
            }
            result.Read = value1;
            bool value2 = default;
            var write = element.Element("Write");
            if (write != null)
            {
                value2 = (bool)write;
            }
            result.Write = value2;
            RetentionPolicy value3 = default;
            var retentionPolicy = element.Element("RetentionPolicy");
            if (retentionPolicy != null)
            {
                value3 = RetentionPolicy.DeserializeRetentionPolicy(retentionPolicy);
            }
            result.RetentionPolicy = value3;
            return result;
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class EdgeKubernetesRoleStorageClassInfo : IUtf8JsonSerializable, IJsonModel<EdgeKubernetesRoleStorageClassInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EdgeKubernetesRoleStorageClassInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EdgeKubernetesRoleStorageClassInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeKubernetesRoleStorageClassInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeKubernetesRoleStorageClassInfo)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsDefined(KubernetesRoleStorageClassInfoType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(KubernetesRoleStorageClassInfoType);
            }
            if (options.Format != "W" && Optional.IsDefined(PosixCompliant))
            {
                writer.WritePropertyName("posixCompliant"u8);
                writer.WriteStringValue(PosixCompliant.Value.ToString());
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        EdgeKubernetesRoleStorageClassInfo IJsonModel<EdgeKubernetesRoleStorageClassInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeKubernetesRoleStorageClassInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeKubernetesRoleStorageClassInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEdgeKubernetesRoleStorageClassInfo(document.RootElement, options);
        }

        internal static EdgeKubernetesRoleStorageClassInfo DeserializeEdgeKubernetesRoleStorageClassInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string type = default;
            PosixComplianceStatus? posixCompliant = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("posixCompliant"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    posixCompliant = new PosixComplianceStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new EdgeKubernetesRoleStorageClassInfo(name, type, posixCompliant, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EdgeKubernetesRoleStorageClassInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeKubernetesRoleStorageClassInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDataBoxEdgeContext.Default);
                default:
                    throw new FormatException($"The model {nameof(EdgeKubernetesRoleStorageClassInfo)} does not support writing '{options.Format}' format.");
            }
        }

        EdgeKubernetesRoleStorageClassInfo IPersistableModel<EdgeKubernetesRoleStorageClassInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeKubernetesRoleStorageClassInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeEdgeKubernetesRoleStorageClassInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EdgeKubernetesRoleStorageClassInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EdgeKubernetesRoleStorageClassInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

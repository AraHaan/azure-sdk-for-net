// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Confluent.Models
{
    public partial class ClusterEnvironmentEntity : IUtf8JsonSerializable, IJsonModel<ClusterEnvironmentEntity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClusterEnvironmentEntity>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ClusterEnvironmentEntity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterEnvironmentEntity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterEnvironmentEntity)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Environment))
            {
                writer.WritePropertyName("environment"u8);
                writer.WriteStringValue(Environment);
            }
            if (Optional.IsDefined(Related))
            {
                writer.WritePropertyName("related"u8);
                writer.WriteStringValue(Related);
            }
            if (Optional.IsDefined(ResourceName))
            {
                writer.WritePropertyName("resource_name"u8);
                writer.WriteStringValue(ResourceName);
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

        ClusterEnvironmentEntity IJsonModel<ClusterEnvironmentEntity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterEnvironmentEntity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterEnvironmentEntity)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterEnvironmentEntity(document.RootElement, options);
        }

        internal static ClusterEnvironmentEntity DeserializeClusterEnvironmentEntity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string environment = default;
            string related = default;
            string resourceName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("environment"u8))
                {
                    environment = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("related"u8))
                {
                    related = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resource_name"u8))
                {
                    resourceName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ClusterEnvironmentEntity(id, environment, related, resourceName, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ClusterEnvironmentEntity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterEnvironmentEntity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerConfluentContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ClusterEnvironmentEntity)} does not support writing '{options.Format}' format.");
            }
        }

        ClusterEnvironmentEntity IPersistableModel<ClusterEnvironmentEntity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterEnvironmentEntity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeClusterEnvironmentEntity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClusterEnvironmentEntity)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClusterEnvironmentEntity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

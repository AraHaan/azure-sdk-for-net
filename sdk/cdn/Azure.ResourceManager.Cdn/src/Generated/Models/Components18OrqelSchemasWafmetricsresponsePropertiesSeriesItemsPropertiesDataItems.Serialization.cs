// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems : IUtf8JsonSerializable, IJsonModel<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(DateOn))
            {
                writer.WritePropertyName("dateTime"u8);
                writer.WriteStringValue(DateOn.Value, "O");
            }
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteNumberValue(Value.Value);
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

        Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems IJsonModel<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeComponents18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems(document.RootElement, options);
        }

        internal static Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems DeserializeComponents18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? dateTime = default;
            float? value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    value = property.Value.GetSingle();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems(dateTime, value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerCdnContext.Default);
                default:
                    throw new FormatException($"The model {nameof(Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems)} does not support writing '{options.Format}' format.");
            }
        }

        Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems IPersistableModel<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeComponents18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

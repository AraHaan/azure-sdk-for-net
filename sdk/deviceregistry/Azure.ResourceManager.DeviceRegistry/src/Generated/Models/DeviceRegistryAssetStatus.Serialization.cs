// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DeviceRegistry.Models
{
    public partial class DeviceRegistryAssetStatus : IUtf8JsonSerializable, IJsonModel<DeviceRegistryAssetStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DeviceRegistryAssetStatus>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DeviceRegistryAssetStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceRegistryAssetStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeviceRegistryAssetStatus)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsCollectionDefined(Errors))
            {
                writer.WritePropertyName("errors"u8);
                writer.WriteStartArray();
                foreach (var item in Errors)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteNumberValue(Version.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Datasets))
            {
                writer.WritePropertyName("datasets"u8);
                writer.WriteStartArray();
                foreach (var item in Datasets)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Events))
            {
                writer.WritePropertyName("events"u8);
                writer.WriteStartArray();
                foreach (var item in Events)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        DeviceRegistryAssetStatus IJsonModel<DeviceRegistryAssetStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceRegistryAssetStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeviceRegistryAssetStatus)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDeviceRegistryAssetStatus(document.RootElement, options);
        }

        internal static DeviceRegistryAssetStatus DeserializeDeviceRegistryAssetStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<DeviceRegistryAssetStatusError> errors = default;
            long? version = default;
            IReadOnlyList<DeviceRegistryAssetStatusDataset> datasets = default;
            IReadOnlyList<DeviceRegistryAssetStatusEvent> events = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DeviceRegistryAssetStatusError> array = new List<DeviceRegistryAssetStatusError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeviceRegistryAssetStatusError.DeserializeDeviceRegistryAssetStatusError(item, options));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    version = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("datasets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DeviceRegistryAssetStatusDataset> array = new List<DeviceRegistryAssetStatusDataset>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeviceRegistryAssetStatusDataset.DeserializeDeviceRegistryAssetStatusDataset(item, options));
                    }
                    datasets = array;
                    continue;
                }
                if (property.NameEquals("events"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DeviceRegistryAssetStatusEvent> array = new List<DeviceRegistryAssetStatusEvent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeviceRegistryAssetStatusEvent.DeserializeDeviceRegistryAssetStatusEvent(item, options));
                    }
                    events = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DeviceRegistryAssetStatus(errors ?? new ChangeTrackingList<DeviceRegistryAssetStatusError>(), version, datasets ?? new ChangeTrackingList<DeviceRegistryAssetStatusDataset>(), events ?? new ChangeTrackingList<DeviceRegistryAssetStatusEvent>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DeviceRegistryAssetStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceRegistryAssetStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDeviceRegistryContext.Default);
                default:
                    throw new FormatException($"The model {nameof(DeviceRegistryAssetStatus)} does not support writing '{options.Format}' format.");
            }
        }

        DeviceRegistryAssetStatus IPersistableModel<DeviceRegistryAssetStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceRegistryAssetStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDeviceRegistryAssetStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DeviceRegistryAssetStatus)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DeviceRegistryAssetStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

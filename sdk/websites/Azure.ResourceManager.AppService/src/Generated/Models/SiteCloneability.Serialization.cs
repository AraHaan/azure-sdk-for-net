// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class SiteCloneability : IUtf8JsonSerializable, IJsonModel<SiteCloneability>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteCloneability>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SiteCloneability>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteCloneability>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteCloneability)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Result))
            {
                writer.WritePropertyName("result"u8);
                writer.WriteStringValue(Result.Value.ToSerialString());
            }
            if (Optional.IsCollectionDefined(BlockingFeatures))
            {
                writer.WritePropertyName("blockingFeatures"u8);
                writer.WriteStartArray();
                foreach (var item in BlockingFeatures)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(UnsupportedFeatures))
            {
                writer.WritePropertyName("unsupportedFeatures"u8);
                writer.WriteStartArray();
                foreach (var item in UnsupportedFeatures)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(BlockingCharacteristics))
            {
                writer.WritePropertyName("blockingCharacteristics"u8);
                writer.WriteStartArray();
                foreach (var item in BlockingCharacteristics)
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

        SiteCloneability IJsonModel<SiteCloneability>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteCloneability>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteCloneability)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteCloneability(document.RootElement, options);
        }

        internal static SiteCloneability DeserializeSiteCloneability(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CloneAbilityResult? result = default;
            IReadOnlyList<SiteCloneabilityCriterion> blockingFeatures = default;
            IReadOnlyList<SiteCloneabilityCriterion> unsupportedFeatures = default;
            IReadOnlyList<SiteCloneabilityCriterion> blockingCharacteristics = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("result"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result = property.Value.GetString().ToCloneAbilityResult();
                    continue;
                }
                if (property.NameEquals("blockingFeatures"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteCloneabilityCriterion> array = new List<SiteCloneabilityCriterion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteCloneabilityCriterion.DeserializeSiteCloneabilityCriterion(item, options));
                    }
                    blockingFeatures = array;
                    continue;
                }
                if (property.NameEquals("unsupportedFeatures"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteCloneabilityCriterion> array = new List<SiteCloneabilityCriterion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteCloneabilityCriterion.DeserializeSiteCloneabilityCriterion(item, options));
                    }
                    unsupportedFeatures = array;
                    continue;
                }
                if (property.NameEquals("blockingCharacteristics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteCloneabilityCriterion> array = new List<SiteCloneabilityCriterion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteCloneabilityCriterion.DeserializeSiteCloneabilityCriterion(item, options));
                    }
                    blockingCharacteristics = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SiteCloneability(result, blockingFeatures ?? new ChangeTrackingList<SiteCloneabilityCriterion>(), unsupportedFeatures ?? new ChangeTrackingList<SiteCloneabilityCriterion>(), blockingCharacteristics ?? new ChangeTrackingList<SiteCloneabilityCriterion>(), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Result), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  result: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Result))
                {
                    builder.Append("  result: ");
                    builder.AppendLine($"'{Result.Value.ToSerialString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BlockingFeatures), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  blockingFeatures: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(BlockingFeatures))
                {
                    if (BlockingFeatures.Any())
                    {
                        builder.Append("  blockingFeatures: ");
                        builder.AppendLine("[");
                        foreach (var item in BlockingFeatures)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  blockingFeatures: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UnsupportedFeatures), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  unsupportedFeatures: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(UnsupportedFeatures))
                {
                    if (UnsupportedFeatures.Any())
                    {
                        builder.Append("  unsupportedFeatures: ");
                        builder.AppendLine("[");
                        foreach (var item in UnsupportedFeatures)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  unsupportedFeatures: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BlockingCharacteristics), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  blockingCharacteristics: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(BlockingCharacteristics))
                {
                    if (BlockingCharacteristics.Any())
                    {
                        builder.Append("  blockingCharacteristics: ");
                        builder.AppendLine("[");
                        foreach (var item in BlockingCharacteristics)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  blockingCharacteristics: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<SiteCloneability>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteCloneability>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerAppServiceContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SiteCloneability)} does not support writing '{options.Format}' format.");
            }
        }

        SiteCloneability IPersistableModel<SiteCloneability>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteCloneability>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSiteCloneability(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SiteCloneability)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteCloneability>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

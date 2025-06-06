// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    public partial class PostgreSqlFlexibleServerBackupProperties : IUtf8JsonSerializable, IJsonModel<PostgreSqlFlexibleServerBackupProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PostgreSqlFlexibleServerBackupProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PostgreSqlFlexibleServerBackupProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerBackupProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerBackupProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(BackupRetentionDays))
            {
                writer.WritePropertyName("backupRetentionDays"u8);
                writer.WriteNumberValue(BackupRetentionDays.Value);
            }
            if (Optional.IsDefined(GeoRedundantBackup))
            {
                writer.WritePropertyName("geoRedundantBackup"u8);
                writer.WriteStringValue(GeoRedundantBackup.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(EarliestRestoreOn))
            {
                writer.WritePropertyName("earliestRestoreDate"u8);
                writer.WriteStringValue(EarliestRestoreOn.Value, "O");
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

        PostgreSqlFlexibleServerBackupProperties IJsonModel<PostgreSqlFlexibleServerBackupProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerBackupProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerBackupProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlFlexibleServerBackupProperties(document.RootElement, options);
        }

        internal static PostgreSqlFlexibleServerBackupProperties DeserializePostgreSqlFlexibleServerBackupProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? backupRetentionDays = default;
            PostgreSqlFlexibleServerGeoRedundantBackupEnum? geoRedundantBackup = default;
            DateTimeOffset? earliestRestoreDate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("backupRetentionDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupRetentionDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("geoRedundantBackup"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    geoRedundantBackup = new PostgreSqlFlexibleServerGeoRedundantBackupEnum(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("earliestRestoreDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    earliestRestoreDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PostgreSqlFlexibleServerBackupProperties(backupRetentionDays, geoRedundantBackup, earliestRestoreDate, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BackupRetentionDays), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  backupRetentionDays: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(BackupRetentionDays))
                {
                    builder.Append("  backupRetentionDays: ");
                    builder.AppendLine($"{BackupRetentionDays.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(GeoRedundantBackup), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  geoRedundantBackup: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(GeoRedundantBackup))
                {
                    builder.Append("  geoRedundantBackup: ");
                    builder.AppendLine($"'{GeoRedundantBackup.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EarliestRestoreOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  earliestRestoreDate: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EarliestRestoreOn))
                {
                    builder.Append("  earliestRestoreDate: ");
                    var formattedDateTimeString = TypeFormatters.ToString(EarliestRestoreOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<PostgreSqlFlexibleServerBackupProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerBackupProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerPostgreSqlContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerBackupProperties)} does not support writing '{options.Format}' format.");
            }
        }

        PostgreSqlFlexibleServerBackupProperties IPersistableModel<PostgreSqlFlexibleServerBackupProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerBackupProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializePostgreSqlFlexibleServerBackupProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerBackupProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PostgreSqlFlexibleServerBackupProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

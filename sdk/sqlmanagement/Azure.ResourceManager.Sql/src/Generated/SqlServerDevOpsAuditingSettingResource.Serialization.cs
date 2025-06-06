// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Sql
{
    public partial class SqlServerDevOpsAuditingSettingResource : IJsonModel<SqlServerDevOpsAuditingSettingData>
    {
        private static SqlServerDevOpsAuditingSettingData s_dataDeserializationInstance;
        private static SqlServerDevOpsAuditingSettingData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<SqlServerDevOpsAuditingSettingData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SqlServerDevOpsAuditingSettingData>)Data).Write(writer, options);

        SqlServerDevOpsAuditingSettingData IJsonModel<SqlServerDevOpsAuditingSettingData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SqlServerDevOpsAuditingSettingData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<SqlServerDevOpsAuditingSettingData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<SqlServerDevOpsAuditingSettingData>(Data, options, AzureResourceManagerSqlContext.Default);

        SqlServerDevOpsAuditingSettingData IPersistableModel<SqlServerDevOpsAuditingSettingData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SqlServerDevOpsAuditingSettingData>(data, options, AzureResourceManagerSqlContext.Default);

        string IPersistableModel<SqlServerDevOpsAuditingSettingData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SqlServerDevOpsAuditingSettingData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}

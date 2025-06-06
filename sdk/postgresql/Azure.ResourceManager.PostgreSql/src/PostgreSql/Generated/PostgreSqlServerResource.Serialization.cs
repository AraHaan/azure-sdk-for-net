// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.PostgreSql
{
    public partial class PostgreSqlServerResource : IJsonModel<PostgreSqlServerData>
    {
        private static PostgreSqlServerData s_dataDeserializationInstance;
        private static PostgreSqlServerData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<PostgreSqlServerData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<PostgreSqlServerData>)Data).Write(writer, options);

        PostgreSqlServerData IJsonModel<PostgreSqlServerData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<PostgreSqlServerData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<PostgreSqlServerData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<PostgreSqlServerData>(Data, options, AzureResourceManagerPostgreSqlContext.Default);

        PostgreSqlServerData IPersistableModel<PostgreSqlServerData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<PostgreSqlServerData>(data, options, AzureResourceManagerPostgreSqlContext.Default);

        string IPersistableModel<PostgreSqlServerData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<PostgreSqlServerData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}

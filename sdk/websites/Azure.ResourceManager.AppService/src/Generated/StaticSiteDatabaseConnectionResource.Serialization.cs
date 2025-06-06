// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.AppService
{
    public partial class StaticSiteDatabaseConnectionResource : IJsonModel<StaticSiteDatabaseConnectionData>
    {
        private static StaticSiteDatabaseConnectionData s_dataDeserializationInstance;
        private static StaticSiteDatabaseConnectionData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<StaticSiteDatabaseConnectionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<StaticSiteDatabaseConnectionData>)Data).Write(writer, options);

        StaticSiteDatabaseConnectionData IJsonModel<StaticSiteDatabaseConnectionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<StaticSiteDatabaseConnectionData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<StaticSiteDatabaseConnectionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<StaticSiteDatabaseConnectionData>(Data, options, AzureResourceManagerAppServiceContext.Default);

        StaticSiteDatabaseConnectionData IPersistableModel<StaticSiteDatabaseConnectionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<StaticSiteDatabaseConnectionData>(data, options, AzureResourceManagerAppServiceContext.Default);

        string IPersistableModel<StaticSiteDatabaseConnectionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<StaticSiteDatabaseConnectionData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}

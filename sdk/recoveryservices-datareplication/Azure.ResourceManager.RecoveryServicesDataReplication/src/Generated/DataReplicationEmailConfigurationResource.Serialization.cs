// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.RecoveryServicesDataReplication
{
    public partial class DataReplicationEmailConfigurationResource : IJsonModel<DataReplicationEmailConfigurationData>
    {
        private static DataReplicationEmailConfigurationData s_dataDeserializationInstance;
        private static DataReplicationEmailConfigurationData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<DataReplicationEmailConfigurationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<DataReplicationEmailConfigurationData>)Data).Write(writer, options);

        DataReplicationEmailConfigurationData IJsonModel<DataReplicationEmailConfigurationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<DataReplicationEmailConfigurationData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<DataReplicationEmailConfigurationData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<DataReplicationEmailConfigurationData>(Data, options, AzureResourceManagerRecoveryServicesDataReplicationContext.Default);

        DataReplicationEmailConfigurationData IPersistableModel<DataReplicationEmailConfigurationData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<DataReplicationEmailConfigurationData>(data, options, AzureResourceManagerRecoveryServicesDataReplicationContext.Default);

        string IPersistableModel<DataReplicationEmailConfigurationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<DataReplicationEmailConfigurationData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}

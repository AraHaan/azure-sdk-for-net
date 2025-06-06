// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    public partial class SiteRecoveryAlertResource : IJsonModel<SiteRecoveryAlertData>
    {
        private static SiteRecoveryAlertData s_dataDeserializationInstance;
        private static SiteRecoveryAlertData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<SiteRecoveryAlertData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SiteRecoveryAlertData>)Data).Write(writer, options);

        SiteRecoveryAlertData IJsonModel<SiteRecoveryAlertData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SiteRecoveryAlertData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<SiteRecoveryAlertData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<SiteRecoveryAlertData>(Data, options, AzureResourceManagerRecoveryServicesSiteRecoveryContext.Default);

        SiteRecoveryAlertData IPersistableModel<SiteRecoveryAlertData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SiteRecoveryAlertData>(data, options, AzureResourceManagerRecoveryServicesSiteRecoveryContext.Default);

        string IPersistableModel<SiteRecoveryAlertData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SiteRecoveryAlertData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}

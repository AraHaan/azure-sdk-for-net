// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Subscription
{
    public partial class TenantPolicyResource : IJsonModel<TenantPolicyData>
    {
        private static TenantPolicyData s_dataDeserializationInstance;
        private static TenantPolicyData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<TenantPolicyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<TenantPolicyData>)Data).Write(writer, options);

        TenantPolicyData IJsonModel<TenantPolicyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<TenantPolicyData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<TenantPolicyData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<TenantPolicyData>(Data, options, AzureResourceManagerSubscriptionContext.Default);

        TenantPolicyData IPersistableModel<TenantPolicyData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<TenantPolicyData>(data, options, AzureResourceManagerSubscriptionContext.Default);

        string IPersistableModel<TenantPolicyData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<TenantPolicyData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}

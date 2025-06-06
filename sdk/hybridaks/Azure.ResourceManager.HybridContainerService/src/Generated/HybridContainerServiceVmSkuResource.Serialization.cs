// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.HybridContainerService
{
    public partial class HybridContainerServiceVmSkuResource : IJsonModel<HybridContainerServiceVmSkuData>
    {
        private static HybridContainerServiceVmSkuData s_dataDeserializationInstance;
        private static HybridContainerServiceVmSkuData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<HybridContainerServiceVmSkuData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<HybridContainerServiceVmSkuData>)Data).Write(writer, options);

        HybridContainerServiceVmSkuData IJsonModel<HybridContainerServiceVmSkuData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<HybridContainerServiceVmSkuData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<HybridContainerServiceVmSkuData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<HybridContainerServiceVmSkuData>(Data, options, AzureResourceManagerHybridContainerServiceContext.Default);

        HybridContainerServiceVmSkuData IPersistableModel<HybridContainerServiceVmSkuData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<HybridContainerServiceVmSkuData>(data, options, AzureResourceManagerHybridContainerServiceContext.Default);

        string IPersistableModel<HybridContainerServiceVmSkuData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<HybridContainerServiceVmSkuData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}

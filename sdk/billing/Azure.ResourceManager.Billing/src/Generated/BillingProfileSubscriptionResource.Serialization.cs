// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Billing
{
    public partial class BillingProfileSubscriptionResource : IJsonModel<BillingSubscriptionData>
    {
        void IJsonModel<BillingSubscriptionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<BillingSubscriptionData>)Data).Write(writer, options);

        BillingSubscriptionData IJsonModel<BillingSubscriptionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<BillingSubscriptionData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<BillingSubscriptionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        BillingSubscriptionData IPersistableModel<BillingSubscriptionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<BillingSubscriptionData>(data, options);

        string IPersistableModel<BillingSubscriptionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<BillingSubscriptionData>)Data).GetFormatFromOptions(options);
    }
}

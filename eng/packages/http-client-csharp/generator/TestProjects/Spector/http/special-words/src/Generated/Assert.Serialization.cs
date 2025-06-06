// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace SpecialWords._Models
{
    public partial class Assert : IJsonModel<Assert>
    {
        internal Assert() => throw null;

        void IJsonModel<Assert>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        Assert IJsonModel<Assert>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        protected virtual Assert JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        BinaryData IPersistableModel<Assert>.Write(ModelReaderWriterOptions options) => throw null;

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options) => throw null;

        Assert IPersistableModel<Assert>.Create(BinaryData data, ModelReaderWriterOptions options) => throw null;

        protected virtual Assert PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options) => throw null;

        string IPersistableModel<Assert>.GetFormatFromOptions(ModelReaderWriterOptions options) => throw null;

        /// <param name="assert"> The <see cref="Assert"/> to serialize into <see cref="RequestContent"/>. </param>
        public static implicit operator RequestContent(Assert assert) => throw null;
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace _Type.Property.ValueTypes
{
    public partial class BooleanProperty : IJsonModel<BooleanProperty>
    {
        internal BooleanProperty() => throw null;

        void IJsonModel<BooleanProperty>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        BooleanProperty IJsonModel<BooleanProperty>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        protected virtual BooleanProperty JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        BinaryData IPersistableModel<BooleanProperty>.Write(ModelReaderWriterOptions options) => throw null;

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options) => throw null;

        BooleanProperty IPersistableModel<BooleanProperty>.Create(BinaryData data, ModelReaderWriterOptions options) => throw null;

        protected virtual BooleanProperty PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options) => throw null;

        string IPersistableModel<BooleanProperty>.GetFormatFromOptions(ModelReaderWriterOptions options) => throw null;

        /// <param name="booleanProperty"> The <see cref="BooleanProperty"/> to serialize into <see cref="RequestContent"/>. </param>
        public static implicit operator RequestContent(BooleanProperty booleanProperty) => throw null;

        public static explicit operator BooleanProperty(Response result) => throw null;
    }
}

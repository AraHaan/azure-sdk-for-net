// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace _Specs_.Azure.ClientGenerator.Core.FlattenProperty
{
    public partial class ChildFlattenModel : IJsonModel<ChildFlattenModel>
    {
        internal ChildFlattenModel() => throw null;

        void IJsonModel<ChildFlattenModel>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        ChildFlattenModel IJsonModel<ChildFlattenModel>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        protected virtual ChildFlattenModel JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        BinaryData IPersistableModel<ChildFlattenModel>.Write(ModelReaderWriterOptions options) => throw null;

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options) => throw null;

        ChildFlattenModel IPersistableModel<ChildFlattenModel>.Create(BinaryData data, ModelReaderWriterOptions options) => throw null;

        protected virtual ChildFlattenModel PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options) => throw null;

        string IPersistableModel<ChildFlattenModel>.GetFormatFromOptions(ModelReaderWriterOptions options) => throw null;
    }
}

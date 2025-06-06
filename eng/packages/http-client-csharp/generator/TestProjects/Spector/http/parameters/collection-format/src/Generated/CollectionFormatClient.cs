// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core.Pipeline;
using Parameters.CollectionFormat._Header;
using Parameters.CollectionFormat._Query;

namespace Parameters.CollectionFormat
{
    public partial class CollectionFormatClient
    {
        public CollectionFormatClient() : this(new Uri("http://localhost:3000"), new CollectionFormatClientOptions()) => throw null;

        public CollectionFormatClient(Uri endpoint, CollectionFormatClientOptions options) => throw null;

        public virtual HttpPipeline Pipeline => throw null;

        public virtual Query GetQueryClient() => throw null;

        public virtual Header GetHeaderClient() => throw null;
    }
}

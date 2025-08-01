// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core.Pipeline;
using _Specs_.Azure.ClientGenerator.Core.Access._InternalOperation;
using _Specs_.Azure.ClientGenerator.Core.Access._PublicOperation;
using _Specs_.Azure.ClientGenerator.Core.Access._RelativeModelInOperation;
using _Specs_.Azure.ClientGenerator.Core.Access._SharedModelInOperation;

namespace _Specs_.Azure.ClientGenerator.Core.Access
{
    public partial class AccessClient
    {
        public AccessClient() : this(new Uri("http://localhost:3000"), new AccessClientOptions()) => throw null;

        public AccessClient(Uri endpoint, AccessClientOptions options) => throw null;

        public virtual HttpPipeline Pipeline => throw null;

        public virtual PublicOperation GetPublicOperationClient() => throw null;

        public virtual InternalOperation GetInternalOperationClient() => throw null;

        public virtual SharedModelInOperation GetSharedModelInOperationClient() => throw null;

        public virtual RelativeModelInOperation GetRelativeModelInOperationClient() => throw null;
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Authentication.Union
{
    public partial class UnionClient
    {
        protected UnionClient() => throw null;

        public UnionClient(AzureKeyCredential credential) : this(new Uri("http://localhost:3000"), credential, new UnionClientOptions()) => throw null;

        public UnionClient(TokenCredential credential) : this(new Uri("http://localhost:3000"), credential, new UnionClientOptions()) => throw null;

        public UnionClient(Uri endpoint, AzureKeyCredential credential, UnionClientOptions options) => throw null;

        public UnionClient(Uri endpoint, TokenCredential credential, UnionClientOptions options) => throw null;

        public virtual HttpPipeline Pipeline => throw null;

        public virtual Response ValidKey(RequestContext context) => throw null;

        public virtual Task<Response> ValidKeyAsync(RequestContext context) => throw null;

        public virtual Response ValidKey(CancellationToken cancellationToken = default) => throw null;

        public virtual Task<Response> ValidKeyAsync(CancellationToken cancellationToken = default) => throw null;

        public virtual Response ValidToken(RequestContext context) => throw null;

        public virtual Task<Response> ValidTokenAsync(RequestContext context) => throw null;

        public virtual Response ValidToken(CancellationToken cancellationToken = default) => throw null;

        public virtual Task<Response> ValidTokenAsync(CancellationToken cancellationToken = default) => throw null;
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid
{
    internal class EventGridNamespaceClientOperationSource : IOperationSource<EventGridNamespaceClientResource>
    {
        private readonly ArmClient _client;

        internal EventGridNamespaceClientOperationSource(ArmClient client)
        {
            _client = client;
        }

        EventGridNamespaceClientResource IOperationSource<EventGridNamespaceClientResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<EventGridNamespaceClientData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerEventGridContext.Default);
            return new EventGridNamespaceClientResource(_client, data);
        }

        async ValueTask<EventGridNamespaceClientResource> IOperationSource<EventGridNamespaceClientResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<EventGridNamespaceClientData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerEventGridContext.Default);
            return await Task.FromResult(new EventGridNamespaceClientResource(_client, data)).ConfigureAwait(false);
        }
    }
}

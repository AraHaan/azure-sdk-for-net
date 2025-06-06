// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Network
{
    internal class DscpConfigurationOperationSource : IOperationSource<DscpConfigurationResource>
    {
        private readonly ArmClient _client;

        internal DscpConfigurationOperationSource(ArmClient client)
        {
            _client = client;
        }

        DscpConfigurationResource IOperationSource<DscpConfigurationResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DscpConfigurationData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerNetworkContext.Default);
            return new DscpConfigurationResource(_client, data);
        }

        async ValueTask<DscpConfigurationResource> IOperationSource<DscpConfigurationResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DscpConfigurationData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerNetworkContext.Default);
            return await Task.FromResult(new DscpConfigurationResource(_client, data)).ConfigureAwait(false);
        }
    }
}

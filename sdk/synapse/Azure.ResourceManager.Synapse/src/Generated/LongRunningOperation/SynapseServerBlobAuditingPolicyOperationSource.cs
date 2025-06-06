// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Synapse
{
    internal class SynapseServerBlobAuditingPolicyOperationSource : IOperationSource<SynapseServerBlobAuditingPolicyResource>
    {
        private readonly ArmClient _client;

        internal SynapseServerBlobAuditingPolicyOperationSource(ArmClient client)
        {
            _client = client;
        }

        SynapseServerBlobAuditingPolicyResource IOperationSource<SynapseServerBlobAuditingPolicyResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<SynapseServerBlobAuditingPolicyData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerSynapseContext.Default);
            return new SynapseServerBlobAuditingPolicyResource(_client, data);
        }

        async ValueTask<SynapseServerBlobAuditingPolicyResource> IOperationSource<SynapseServerBlobAuditingPolicyResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<SynapseServerBlobAuditingPolicyData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerSynapseContext.Default);
            return await Task.FromResult(new SynapseServerBlobAuditingPolicyResource(_client, data)).ConfigureAwait(false);
        }
    }
}

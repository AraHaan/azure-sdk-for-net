// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace MgmtTypeSpec
{
    /// <summary></summary>
    public partial class FooResource : ArmResource
    {
        private readonly ClientDiagnostics _foosClientDiagnostics;
        private readonly Foos _foosRestClient;
        private readonly FooData _data;
        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "MgmtTypeSpec/foos";

        /// <summary> Initializes a new instance of FooResource for mocking. </summary>
        protected FooResource()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FooResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal FooResource(ArmClient client, FooData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of <see cref="FooResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal FooResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _foosClientDiagnostics = new ClientDiagnostics("MgmtTypeSpec", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string fooApiVersion);
            _foosRestClient = new Foos(_foosClientDiagnostics, Pipeline, Endpoint, fooApiVersion);
            ValidateResourceId(id);
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        public virtual FooData Data
        {
            get
            {
                if (!HasData)
                {
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                }
                return _data;
            }
        }

        /// <summary> Generate the resource identifier for this resource. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="fooName"> The fooName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string fooName)
        {
            string resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/MgmtTypeSpec/foos/{fooName}";
            return new ResourceIdentifier(resourceId);
        }

        /// <param name="id"></param>
        [Conditional("DEBUG")]
        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
            {
                throw new ArgumentException(string.Format("Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), id);
            }
        }

        /// <summary> Get a Foo. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FooResource> Get(CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _foosClientDiagnostics.CreateScope("FooResource.Get");
            scope.Start();
            try
            {
                RequestContext context = new RequestContext
                {
                    CancellationToken = cancellationToken
                };
                HttpMessage message = _foosRestClient.CreateGetRequest(Guid.Parse(Id.SubscriptionId), Id.ResourceGroupName, Id.Name, context);
                Response result = Pipeline.ProcessMessage(message, context);
                Response<FooData> response = Response.FromValue(FooData.FromResponse(result), result);
                if (response.Value == null)
                {
                    throw new RequestFailedException(response.GetRawResponse());
                }
                return Response.FromValue(new FooResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a Foo. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FooResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _foosClientDiagnostics.CreateScope("FooResource.GetAsync");
            scope.Start();
            try
            {
                RequestContext context = new RequestContext
                {
                    CancellationToken = cancellationToken
                };
                HttpMessage message = _foosRestClient.CreateGetRequest(Guid.Parse(Id.SubscriptionId), Id.ResourceGroupName, Id.Name, context);
                Response result = await Pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
                Response<FooData> response = Response.FromValue(FooData.FromResponse(result), result);
                if (response.Value == null)
                {
                    throw new RequestFailedException(response.GetRawResponse());
                }
                return Response.FromValue(new FooResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete a Foo. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _foosClientDiagnostics.CreateScope("FooResource.Delete");
            scope.Start();
            try
            {
                RequestContext context = new RequestContext
                {
                    CancellationToken = cancellationToken
                };
                HttpMessage message = _foosRestClient.CreateDeleteRequest(Guid.Parse(Id.SubscriptionId), Id.ResourceGroupName, Id.Name, context);
                Response response = Pipeline.ProcessMessage(message, context);
                MgmtTypeSpecArmOperation operation = new MgmtTypeSpecArmOperation(_foosClientDiagnostics, Pipeline, message.Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                {
                    operation.WaitForCompletionResponse(cancellationToken);
                }
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete a Foo. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _foosClientDiagnostics.CreateScope("FooResource.DeleteAsync");
            scope.Start();
            try
            {
                RequestContext context = new RequestContext
                {
                    CancellationToken = cancellationToken
                };
                HttpMessage message = _foosRestClient.CreateDeleteRequest(Guid.Parse(Id.SubscriptionId), Id.ResourceGroupName, Id.Name, context);
                Response response = await Pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
                MgmtTypeSpecArmOperation operation = new MgmtTypeSpecArmOperation(_foosClientDiagnostics, Pipeline, message.Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                {
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                }
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update a Foo. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The resource properties to be updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<FooResource> Update(WaitUntil waitUntil, FooData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using DiagnosticScope scope = _foosClientDiagnostics.CreateScope("FooResource.Update");
            scope.Start();
            try
            {
                RequestContext context = new RequestContext
                {
                    CancellationToken = cancellationToken
                };
                HttpMessage message = _foosRestClient.CreateUpdateRequest(Guid.Parse(Id.SubscriptionId), Id.ResourceGroupName, Id.Name, FooData.ToRequestContent(data), context);
                Response response = Pipeline.ProcessMessage(message, context);
                MgmtTypeSpecArmOperation<FooResource> operation = new MgmtTypeSpecArmOperation<FooResource>(
                    new FooOperationSource(Client),
                    _foosClientDiagnostics,
                    Pipeline,
                    message.Request,
                    response,
                    OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                {
                    operation.WaitForCompletion(cancellationToken);
                }
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update a Foo. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The resource properties to be updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<FooResource>> UpdateAsync(WaitUntil waitUntil, FooData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using DiagnosticScope scope = _foosClientDiagnostics.CreateScope("FooResource.UpdateAsync");
            scope.Start();
            try
            {
                RequestContext context = new RequestContext
                {
                    CancellationToken = cancellationToken
                };
                HttpMessage message = _foosRestClient.CreateUpdateRequest(Guid.Parse(Id.SubscriptionId), Id.ResourceGroupName, Id.Name, FooData.ToRequestContent(data), context);
                Response response = await Pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
                MgmtTypeSpecArmOperation<FooResource> operation = new MgmtTypeSpecArmOperation<FooResource>(
                    new FooOperationSource(Client),
                    _foosClientDiagnostics,
                    Pipeline,
                    message.Request,
                    response,
                    OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                {
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                }
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Add a tag to the current resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual async Task<Response<FooResource>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using DiagnosticScope scope = _foosClientDiagnostics.CreateScope("FooResource.AddTag");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken).ConfigureAwait(false))
                {
                    Response<TagResource> originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues[key] = value;
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken).ConfigureAwait(false);
                    RequestContext context = new RequestContext
                    {
                        CancellationToken = cancellationToken
                    };
                    HttpMessage message = _foosRestClient.CreateGetRequest(Guid.Parse(Id.SubscriptionId), Id.ResourceGroupName, Id.Name, context);
                    Response result = await Pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
                    Response<FooData> response = Response.FromValue(FooData.FromResponse(result), result);
                    return Response.FromValue(new FooResource(Client, response.Value), response.GetRawResponse());
                }
                else
                {
                    FooData current = (await GetAsync(cancellationToken).ConfigureAwait(false)).Value.Data;
                    current.Tags[key] = value;
                    ArmOperation<FooResource> result = await UpdateAsync(WaitUntil.Completed, current, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Add a tag to the current resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<FooResource> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using DiagnosticScope scope = _foosClientDiagnostics.CreateScope("FooResource.AddTag");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken))
                {
                    Response<TagResource> originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues[key] = value;
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken);
                    RequestContext context = new RequestContext
                    {
                        CancellationToken = cancellationToken
                    };
                    HttpMessage message = _foosRestClient.CreateGetRequest(Guid.Parse(Id.SubscriptionId), Id.ResourceGroupName, Id.Name, context);
                    Response result = Pipeline.ProcessMessage(message, context);
                    Response<FooData> response = Response.FromValue(FooData.FromResponse(result), result);
                    return Response.FromValue(new FooResource(Client, response.Value), response.GetRawResponse());
                }
                else
                {
                    FooData current = Get(cancellationToken).Value.Data;
                    current.Tags[key] = value;
                    ArmOperation<FooResource> result = Update(WaitUntil.Completed, current, cancellationToken);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Replace the tags on the resource with the given set. </summary>
        /// <param name="tags"> The tags to set on the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual async Task<Response<FooResource>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using DiagnosticScope scope = _foosClientDiagnostics.CreateScope("FooResource.SetTags");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken).ConfigureAwait(false))
                {
                    await GetTagResource().DeleteAsync(WaitUntil.Completed, cancellationToken).ConfigureAwait(false);
                    Response<TagResource> originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues.ReplaceWith(tags);
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken).ConfigureAwait(false);
                    RequestContext context = new RequestContext
                    {
                        CancellationToken = cancellationToken
                    };
                    HttpMessage message = _foosRestClient.CreateGetRequest(Guid.Parse(Id.SubscriptionId), Id.ResourceGroupName, Id.Name, context);
                    Response result = await Pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
                    Response<FooData> response = Response.FromValue(FooData.FromResponse(result), result);
                    return Response.FromValue(new FooResource(Client, response.Value), response.GetRawResponse());
                }
                else
                {
                    FooData current = (await GetAsync(cancellationToken).ConfigureAwait(false)).Value.Data;
                    current.Tags.ReplaceWith(tags);
                    ArmOperation<FooResource> result = await UpdateAsync(WaitUntil.Completed, current, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Replace the tags on the resource with the given set. </summary>
        /// <param name="tags"> The tags to set on the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<FooResource> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using DiagnosticScope scope = _foosClientDiagnostics.CreateScope("FooResource.SetTags");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken))
                {
                    GetTagResource().Delete(WaitUntil.Completed, cancellationToken);
                    Response<TagResource> originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues.ReplaceWith(tags);
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken);
                    RequestContext context = new RequestContext
                    {
                        CancellationToken = cancellationToken
                    };
                    HttpMessage message = _foosRestClient.CreateGetRequest(Guid.Parse(Id.SubscriptionId), Id.ResourceGroupName, Id.Name, context);
                    Response result = Pipeline.ProcessMessage(message, context);
                    Response<FooData> response = Response.FromValue(FooData.FromResponse(result), result);
                    return Response.FromValue(new FooResource(Client, response.Value), response.GetRawResponse());
                }
                else
                {
                    FooData current = Get(cancellationToken).Value.Data;
                    current.Tags.ReplaceWith(tags);
                    ArmOperation<FooResource> result = Update(WaitUntil.Completed, current, cancellationToken);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Removes a tag by key from the resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual async Task<Response<FooResource>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using DiagnosticScope scope = _foosClientDiagnostics.CreateScope("FooResource.RemoveTag");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken).ConfigureAwait(false))
                {
                    Response<TagResource> originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues.Remove(key);
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken).ConfigureAwait(false);
                    RequestContext context = new RequestContext
                    {
                        CancellationToken = cancellationToken
                    };
                    HttpMessage message = _foosRestClient.CreateGetRequest(Guid.Parse(Id.SubscriptionId), Id.ResourceGroupName, Id.Name, context);
                    Response result = await Pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
                    Response<FooData> response = Response.FromValue(FooData.FromResponse(result), result);
                    return Response.FromValue(new FooResource(Client, response.Value), response.GetRawResponse());
                }
                else
                {
                    FooData current = (await GetAsync(cancellationToken).ConfigureAwait(false)).Value.Data;
                    current.Tags.Remove(key);
                    ArmOperation<FooResource> result = await UpdateAsync(WaitUntil.Completed, current, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Removes a tag by key from the resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<FooResource> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using DiagnosticScope scope = _foosClientDiagnostics.CreateScope("FooResource.RemoveTag");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken))
                {
                    Response<TagResource> originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues.Remove(key);
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken);
                    RequestContext context = new RequestContext
                    {
                        CancellationToken = cancellationToken
                    };
                    HttpMessage message = _foosRestClient.CreateGetRequest(Guid.Parse(Id.SubscriptionId), Id.ResourceGroupName, Id.Name, context);
                    Response result = Pipeline.ProcessMessage(message, context);
                    Response<FooData> response = Response.FromValue(FooData.FromResponse(result), result);
                    return Response.FromValue(new FooResource(Client, response.Value), response.GetRawResponse());
                }
                else
                {
                    FooData current = Get(cancellationToken).Value.Data;
                    current.Tags.Remove(key);
                    ArmOperation<FooResource> result = Update(WaitUntil.Completed, current, cancellationToken);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a collection of Bars in the Foo. </summary>
        /// <returns> An object representing collection of Bars and their operations over a Foo. </returns>
        public virtual BarCollection GetBars()
        {
            return GetCachedClient(client => new BarCollection(client, Id));
        }
    }
}

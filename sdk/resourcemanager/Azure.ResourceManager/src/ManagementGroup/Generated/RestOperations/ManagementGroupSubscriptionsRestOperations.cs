// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.ManagementGroups.Models;

namespace Azure.ResourceManager.ManagementGroups
{
    internal partial class ManagementGroupSubscriptionsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ManagementGroupSubscriptionsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ManagementGroupSubscriptionsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2021-04-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateCreateRequestUri(string groupId, string subscriptionId, string cacheControl)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Management/managementGroups/", false);
            uri.AppendPath(groupId, true);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateCreateRequest(string groupId, string subscriptionId, string cacheControl)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Management/managementGroups/", false);
            uri.AppendPath(groupId, true);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            if (cacheControl != null)
            {
                request.Headers.Add("Cache-Control", cacheControl);
            }
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary>
        /// Associates existing subscription with the management group.
        ///
        /// </summary>
        /// <param name="groupId"> Management Group ID. </param>
        /// <param name="subscriptionId"> Subscription ID. </param>
        /// <param name="cacheControl"> Indicates whether the request should utilize any caches. Populate the header with 'no-cache' value to bypass existing caches. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="groupId"/> or <paramref name="subscriptionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="groupId"/> or <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ManagementGroupSubscriptionData>> CreateAsync(string groupId, string subscriptionId, string cacheControl = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupId, nameof(groupId));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using var message = CreateCreateRequest(groupId, subscriptionId, cacheControl);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ManagementGroupSubscriptionData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = ManagementGroupSubscriptionData.DeserializeManagementGroupSubscriptionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary>
        /// Associates existing subscription with the management group.
        ///
        /// </summary>
        /// <param name="groupId"> Management Group ID. </param>
        /// <param name="subscriptionId"> Subscription ID. </param>
        /// <param name="cacheControl"> Indicates whether the request should utilize any caches. Populate the header with 'no-cache' value to bypass existing caches. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="groupId"/> or <paramref name="subscriptionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="groupId"/> or <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ManagementGroupSubscriptionData> Create(string groupId, string subscriptionId, string cacheControl = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupId, nameof(groupId));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using var message = CreateCreateRequest(groupId, subscriptionId, cacheControl);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ManagementGroupSubscriptionData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = ManagementGroupSubscriptionData.DeserializeManagementGroupSubscriptionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateDeleteRequestUri(string groupId, string subscriptionId, string cacheControl)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Management/managementGroups/", false);
            uri.AppendPath(groupId, true);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateDeleteRequest(string groupId, string subscriptionId, string cacheControl)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Management/managementGroups/", false);
            uri.AppendPath(groupId, true);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            if (cacheControl != null)
            {
                request.Headers.Add("Cache-Control", cacheControl);
            }
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary>
        /// De-associates subscription from the management group.
        ///
        /// </summary>
        /// <param name="groupId"> Management Group ID. </param>
        /// <param name="subscriptionId"> Subscription ID. </param>
        /// <param name="cacheControl"> Indicates whether the request should utilize any caches. Populate the header with 'no-cache' value to bypass existing caches. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="groupId"/> or <paramref name="subscriptionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="groupId"/> or <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string groupId, string subscriptionId, string cacheControl = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupId, nameof(groupId));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using var message = CreateDeleteRequest(groupId, subscriptionId, cacheControl);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary>
        /// De-associates subscription from the management group.
        ///
        /// </summary>
        /// <param name="groupId"> Management Group ID. </param>
        /// <param name="subscriptionId"> Subscription ID. </param>
        /// <param name="cacheControl"> Indicates whether the request should utilize any caches. Populate the header with 'no-cache' value to bypass existing caches. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="groupId"/> or <paramref name="subscriptionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="groupId"/> or <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string groupId, string subscriptionId, string cacheControl = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupId, nameof(groupId));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using var message = CreateDeleteRequest(groupId, subscriptionId, cacheControl);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetSubscriptionRequestUri(string groupId, string subscriptionId, string cacheControl)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Management/managementGroups/", false);
            uri.AppendPath(groupId, true);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetSubscriptionRequest(string groupId, string subscriptionId, string cacheControl)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Management/managementGroups/", false);
            uri.AppendPath(groupId, true);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            if (cacheControl != null)
            {
                request.Headers.Add("Cache-Control", cacheControl);
            }
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary>
        /// Retrieves details about given subscription which is associated with the management group.
        ///
        /// </summary>
        /// <param name="groupId"> Management Group ID. </param>
        /// <param name="subscriptionId"> Subscription ID. </param>
        /// <param name="cacheControl"> Indicates whether the request should utilize any caches. Populate the header with 'no-cache' value to bypass existing caches. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="groupId"/> or <paramref name="subscriptionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="groupId"/> or <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ManagementGroupSubscriptionData>> GetSubscriptionAsync(string groupId, string subscriptionId, string cacheControl = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupId, nameof(groupId));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using var message = CreateGetSubscriptionRequest(groupId, subscriptionId, cacheControl);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ManagementGroupSubscriptionData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = ManagementGroupSubscriptionData.DeserializeManagementGroupSubscriptionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ManagementGroupSubscriptionData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary>
        /// Retrieves details about given subscription which is associated with the management group.
        ///
        /// </summary>
        /// <param name="groupId"> Management Group ID. </param>
        /// <param name="subscriptionId"> Subscription ID. </param>
        /// <param name="cacheControl"> Indicates whether the request should utilize any caches. Populate the header with 'no-cache' value to bypass existing caches. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="groupId"/> or <paramref name="subscriptionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="groupId"/> or <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ManagementGroupSubscriptionData> GetSubscription(string groupId, string subscriptionId, string cacheControl = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupId, nameof(groupId));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using var message = CreateGetSubscriptionRequest(groupId, subscriptionId, cacheControl);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ManagementGroupSubscriptionData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = ManagementGroupSubscriptionData.DeserializeManagementGroupSubscriptionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ManagementGroupSubscriptionData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetSubscriptionsUnderManagementGroupRequestUri(string groupId, string skipToken)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Management/managementGroups/", false);
            uri.AppendPath(groupId, true);
            uri.AppendPath("/subscriptions", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (skipToken != null)
            {
                uri.AppendQuery("$skiptoken", skipToken, true);
            }
            return uri;
        }

        internal HttpMessage CreateGetSubscriptionsUnderManagementGroupRequest(string groupId, string skipToken)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Management/managementGroups/", false);
            uri.AppendPath(groupId, true);
            uri.AppendPath("/subscriptions", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (skipToken != null)
            {
                uri.AppendQuery("$skiptoken", skipToken, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary>
        /// Retrieves details about all subscriptions which are associated with the management group.
        ///
        /// </summary>
        /// <param name="groupId"> Management Group ID. </param>
        /// <param name="skipToken">
        /// Page continuation token is only used if a previous operation returned a partial result.
        /// If a previous response contains a nextLink element, the value of the nextLink element will include a token parameter that specifies a starting point to use for subsequent calls.
        ///
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="groupId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="groupId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ListSubscriptionUnderManagementGroup>> GetSubscriptionsUnderManagementGroupAsync(string groupId, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupId, nameof(groupId));

            using var message = CreateGetSubscriptionsUnderManagementGroupRequest(groupId, skipToken);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListSubscriptionUnderManagementGroup value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = ListSubscriptionUnderManagementGroup.DeserializeListSubscriptionUnderManagementGroup(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary>
        /// Retrieves details about all subscriptions which are associated with the management group.
        ///
        /// </summary>
        /// <param name="groupId"> Management Group ID. </param>
        /// <param name="skipToken">
        /// Page continuation token is only used if a previous operation returned a partial result.
        /// If a previous response contains a nextLink element, the value of the nextLink element will include a token parameter that specifies a starting point to use for subsequent calls.
        ///
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="groupId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="groupId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ListSubscriptionUnderManagementGroup> GetSubscriptionsUnderManagementGroup(string groupId, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupId, nameof(groupId));

            using var message = CreateGetSubscriptionsUnderManagementGroupRequest(groupId, skipToken);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListSubscriptionUnderManagementGroup value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = ListSubscriptionUnderManagementGroup.DeserializeListSubscriptionUnderManagementGroup(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetSubscriptionsUnderManagementGroupNextPageRequestUri(string nextLink, string groupId, string skipToken)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateGetSubscriptionsUnderManagementGroupNextPageRequest(string nextLink, string groupId, string skipToken)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary>
        /// Retrieves details about all subscriptions which are associated with the management group.
        ///
        /// </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="groupId"> Management Group ID. </param>
        /// <param name="skipToken">
        /// Page continuation token is only used if a previous operation returned a partial result.
        /// If a previous response contains a nextLink element, the value of the nextLink element will include a token parameter that specifies a starting point to use for subsequent calls.
        ///
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="groupId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="groupId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ListSubscriptionUnderManagementGroup>> GetSubscriptionsUnderManagementGroupNextPageAsync(string nextLink, string groupId, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(groupId, nameof(groupId));

            using var message = CreateGetSubscriptionsUnderManagementGroupNextPageRequest(nextLink, groupId, skipToken);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListSubscriptionUnderManagementGroup value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = ListSubscriptionUnderManagementGroup.DeserializeListSubscriptionUnderManagementGroup(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary>
        /// Retrieves details about all subscriptions which are associated with the management group.
        ///
        /// </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="groupId"> Management Group ID. </param>
        /// <param name="skipToken">
        /// Page continuation token is only used if a previous operation returned a partial result.
        /// If a previous response contains a nextLink element, the value of the nextLink element will include a token parameter that specifies a starting point to use for subsequent calls.
        ///
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="groupId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="groupId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ListSubscriptionUnderManagementGroup> GetSubscriptionsUnderManagementGroupNextPage(string nextLink, string groupId, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(groupId, nameof(groupId));

            using var message = CreateGetSubscriptionsUnderManagementGroupNextPageRequest(nextLink, groupId, skipToken);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListSubscriptionUnderManagementGroup value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = ListSubscriptionUnderManagementGroup.DeserializeListSubscriptionUnderManagementGroup(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}

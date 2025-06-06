// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A Class representing a PolicySignaturesOverridesForIdps along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="PolicySignaturesOverridesForIdpsResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetPolicySignaturesOverridesForIdpsResource method.
    /// Otherwise you can get one from its parent resource <see cref="FirewallPolicyResource"/> using the GetPolicySignaturesOverridesForIdps method.
    /// </summary>
    public partial class PolicySignaturesOverridesForIdpsResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="PolicySignaturesOverridesForIdpsResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="firewallPolicyName"> The firewallPolicyName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string firewallPolicyName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/firewallPolicies/{firewallPolicyName}/signatureOverrides/default";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _policySignaturesOverridesForIdpsFirewallPolicyIdpsSignaturesOverridesClientDiagnostics;
        private readonly FirewallPolicyIdpsSignaturesOverridesRestOperations _policySignaturesOverridesForIdpsFirewallPolicyIdpsSignaturesOverridesRestClient;
        private readonly PolicySignaturesOverridesForIdpsData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/firewallPolicies/signatureOverrides";

        /// <summary> Initializes a new instance of the <see cref="PolicySignaturesOverridesForIdpsResource"/> class for mocking. </summary>
        protected PolicySignaturesOverridesForIdpsResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PolicySignaturesOverridesForIdpsResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal PolicySignaturesOverridesForIdpsResource(ArmClient client, PolicySignaturesOverridesForIdpsData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="PolicySignaturesOverridesForIdpsResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal PolicySignaturesOverridesForIdpsResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _policySignaturesOverridesForIdpsFirewallPolicyIdpsSignaturesOverridesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string policySignaturesOverridesForIdpsFirewallPolicyIdpsSignaturesOverridesApiVersion);
            _policySignaturesOverridesForIdpsFirewallPolicyIdpsSignaturesOverridesRestClient = new FirewallPolicyIdpsSignaturesOverridesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, policySignaturesOverridesForIdpsFirewallPolicyIdpsSignaturesOverridesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual PolicySignaturesOverridesForIdpsData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Returns all signatures overrides for a specific policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/firewallPolicies/{firewallPolicyName}/signatureOverrides/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallPolicyIdpsSignaturesOverrides_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PolicySignaturesOverridesForIdpsResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PolicySignaturesOverridesForIdpsResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _policySignaturesOverridesForIdpsFirewallPolicyIdpsSignaturesOverridesClientDiagnostics.CreateScope("PolicySignaturesOverridesForIdpsResource.Get");
            scope.Start();
            try
            {
                var response = await _policySignaturesOverridesForIdpsFirewallPolicyIdpsSignaturesOverridesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PolicySignaturesOverridesForIdpsResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns all signatures overrides for a specific policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/firewallPolicies/{firewallPolicyName}/signatureOverrides/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallPolicyIdpsSignaturesOverrides_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PolicySignaturesOverridesForIdpsResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PolicySignaturesOverridesForIdpsResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _policySignaturesOverridesForIdpsFirewallPolicyIdpsSignaturesOverridesClientDiagnostics.CreateScope("PolicySignaturesOverridesForIdpsResource.Get");
            scope.Start();
            try
            {
                var response = _policySignaturesOverridesForIdpsFirewallPolicyIdpsSignaturesOverridesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PolicySignaturesOverridesForIdpsResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Will update the status of policy's signature overrides for IDPS
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/firewallPolicies/{firewallPolicyName}/signatureOverrides/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallPolicyIdpsSignaturesOverrides_Patch</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PolicySignaturesOverridesForIdpsResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> Will contain all properties of the object to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<Response<PolicySignaturesOverridesForIdpsResource>> UpdateAsync(PolicySignaturesOverridesForIdpsData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _policySignaturesOverridesForIdpsFirewallPolicyIdpsSignaturesOverridesClientDiagnostics.CreateScope("PolicySignaturesOverridesForIdpsResource.Update");
            scope.Start();
            try
            {
                var response = await _policySignaturesOverridesForIdpsFirewallPolicyIdpsSignaturesOverridesRestClient.PatchAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new PolicySignaturesOverridesForIdpsResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Will update the status of policy's signature overrides for IDPS
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/firewallPolicies/{firewallPolicyName}/signatureOverrides/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallPolicyIdpsSignaturesOverrides_Patch</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PolicySignaturesOverridesForIdpsResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> Will contain all properties of the object to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual Response<PolicySignaturesOverridesForIdpsResource> Update(PolicySignaturesOverridesForIdpsData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _policySignaturesOverridesForIdpsFirewallPolicyIdpsSignaturesOverridesClientDiagnostics.CreateScope("PolicySignaturesOverridesForIdpsResource.Update");
            scope.Start();
            try
            {
                var response = _policySignaturesOverridesForIdpsFirewallPolicyIdpsSignaturesOverridesRestClient.Patch(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken);
                return Response.FromValue(new PolicySignaturesOverridesForIdpsResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Will override/create a new signature overrides for the policy's IDPS
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/firewallPolicies/{firewallPolicyName}/signatureOverrides/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallPolicyIdpsSignaturesOverrides_Put</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PolicySignaturesOverridesForIdpsResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Will contain all properties of the object to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PolicySignaturesOverridesForIdpsResource>> CreateOrUpdateAsync(WaitUntil waitUntil, PolicySignaturesOverridesForIdpsData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _policySignaturesOverridesForIdpsFirewallPolicyIdpsSignaturesOverridesClientDiagnostics.CreateScope("PolicySignaturesOverridesForIdpsResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _policySignaturesOverridesForIdpsFirewallPolicyIdpsSignaturesOverridesRestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken).ConfigureAwait(false);
                var uri = _policySignaturesOverridesForIdpsFirewallPolicyIdpsSignaturesOverridesRestClient.CreatePutRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new NetworkArmOperation<PolicySignaturesOverridesForIdpsResource>(Response.FromValue(new PolicySignaturesOverridesForIdpsResource(Client, response), response.GetRawResponse()), rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Will override/create a new signature overrides for the policy's IDPS
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/firewallPolicies/{firewallPolicyName}/signatureOverrides/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallPolicyIdpsSignaturesOverrides_Put</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PolicySignaturesOverridesForIdpsResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Will contain all properties of the object to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PolicySignaturesOverridesForIdpsResource> CreateOrUpdate(WaitUntil waitUntil, PolicySignaturesOverridesForIdpsData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _policySignaturesOverridesForIdpsFirewallPolicyIdpsSignaturesOverridesClientDiagnostics.CreateScope("PolicySignaturesOverridesForIdpsResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _policySignaturesOverridesForIdpsFirewallPolicyIdpsSignaturesOverridesRestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken);
                var uri = _policySignaturesOverridesForIdpsFirewallPolicyIdpsSignaturesOverridesRestClient.CreatePutRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new NetworkArmOperation<PolicySignaturesOverridesForIdpsResource>(Response.FromValue(new PolicySignaturesOverridesForIdpsResource(Client, response), response.GetRawResponse()), rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}

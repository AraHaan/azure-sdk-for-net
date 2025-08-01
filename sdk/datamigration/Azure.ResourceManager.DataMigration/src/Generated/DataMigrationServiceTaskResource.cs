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
using Azure.ResourceManager.DataMigration.Models;

namespace Azure.ResourceManager.DataMigration
{
    /// <summary>
    /// A Class representing a DataMigrationServiceTask along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="DataMigrationServiceTaskResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetDataMigrationServiceTaskResource method.
    /// Otherwise you can get one from its parent resource <see cref="DataMigrationProjectResource"/> using the GetDataMigrationServiceTask method.
    /// </summary>
    public partial class DataMigrationServiceTaskResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DataMigrationServiceTaskResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="groupName"> The groupName. </param>
        /// <param name="serviceName"> The serviceName. </param>
        /// <param name="projectName"> The projectName. </param>
        /// <param name="taskName"> The taskName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string groupName, string serviceName, string projectName, string taskName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.DataMigration/services/{serviceName}/projects/{projectName}/tasks/{taskName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _dataMigrationServiceTaskTasksClientDiagnostics;
        private readonly TasksRestOperations _dataMigrationServiceTaskTasksRestClient;
        private readonly DataMigrationProjectTaskData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly Core.ResourceType ResourceType = "Microsoft.DataMigration/services/projects/tasks";

        /// <summary> Initializes a new instance of the <see cref="DataMigrationServiceTaskResource"/> class for mocking. </summary>
        protected DataMigrationServiceTaskResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataMigrationServiceTaskResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DataMigrationServiceTaskResource(ArmClient client, DataMigrationProjectTaskData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DataMigrationServiceTaskResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DataMigrationServiceTaskResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataMigrationServiceTaskTasksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataMigration", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string dataMigrationServiceTaskTasksApiVersion);
            _dataMigrationServiceTaskTasksRestClient = new TasksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataMigrationServiceTaskTasksApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DataMigrationProjectTaskData Data
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
        /// The tasks resource is a nested, proxy-only resource representing work performed by a DMS (classic) instance. The GET method retrieves information about a task.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.DataMigration/services/{serviceName}/projects/{projectName}/tasks/{taskName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tasks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataMigrationServiceTaskResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Expand the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DataMigrationServiceTaskResource>> GetAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _dataMigrationServiceTaskTasksClientDiagnostics.CreateScope("DataMigrationServiceTaskResource.Get");
            scope.Start();
            try
            {
                var response = await _dataMigrationServiceTaskTasksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataMigrationServiceTaskResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The tasks resource is a nested, proxy-only resource representing work performed by a DMS (classic) instance. The GET method retrieves information about a task.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.DataMigration/services/{serviceName}/projects/{projectName}/tasks/{taskName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tasks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataMigrationServiceTaskResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Expand the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DataMigrationServiceTaskResource> Get(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _dataMigrationServiceTaskTasksClientDiagnostics.CreateScope("DataMigrationServiceTaskResource.Get");
            scope.Start();
            try
            {
                var response = _dataMigrationServiceTaskTasksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataMigrationServiceTaskResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The tasks resource is a nested, proxy-only resource representing work performed by a DMS (classic) instance. The DELETE method deletes a task, canceling it first if it's running.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.DataMigration/services/{serviceName}/projects/{projectName}/tasks/{taskName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tasks_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataMigrationServiceTaskResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="deleteRunningTasks"> Delete the resource even if it contains running tasks. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, bool? deleteRunningTasks = null, CancellationToken cancellationToken = default)
        {
            using var scope = _dataMigrationServiceTaskTasksClientDiagnostics.CreateScope("DataMigrationServiceTaskResource.Delete");
            scope.Start();
            try
            {
                var response = await _dataMigrationServiceTaskTasksRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, deleteRunningTasks, cancellationToken).ConfigureAwait(false);
                var uri = _dataMigrationServiceTaskTasksRestClient.CreateDeleteRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, deleteRunningTasks);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new DataMigrationArmOperation(response, rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The tasks resource is a nested, proxy-only resource representing work performed by a DMS (classic) instance. The DELETE method deletes a task, canceling it first if it's running.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.DataMigration/services/{serviceName}/projects/{projectName}/tasks/{taskName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tasks_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataMigrationServiceTaskResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="deleteRunningTasks"> Delete the resource even if it contains running tasks. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, bool? deleteRunningTasks = null, CancellationToken cancellationToken = default)
        {
            using var scope = _dataMigrationServiceTaskTasksClientDiagnostics.CreateScope("DataMigrationServiceTaskResource.Delete");
            scope.Start();
            try
            {
                var response = _dataMigrationServiceTaskTasksRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, deleteRunningTasks, cancellationToken);
                var uri = _dataMigrationServiceTaskTasksRestClient.CreateDeleteRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, deleteRunningTasks);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new DataMigrationArmOperation(response, rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The tasks resource is a nested, proxy-only resource representing work performed by a DMS (classic) instance. The PATCH method updates an existing task, but since tasks have no mutable custom properties, there is little reason to do so.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.DataMigration/services/{serviceName}/projects/{projectName}/tasks/{taskName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tasks_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataMigrationServiceTaskResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> Information about the task. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<Response<DataMigrationServiceTaskResource>> UpdateAsync(DataMigrationProjectTaskData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataMigrationServiceTaskTasksClientDiagnostics.CreateScope("DataMigrationServiceTaskResource.Update");
            scope.Start();
            try
            {
                var response = await _dataMigrationServiceTaskTasksRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new DataMigrationServiceTaskResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The tasks resource is a nested, proxy-only resource representing work performed by a DMS (classic) instance. The PATCH method updates an existing task, but since tasks have no mutable custom properties, there is little reason to do so.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.DataMigration/services/{serviceName}/projects/{projectName}/tasks/{taskName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tasks_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataMigrationServiceTaskResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> Information about the task. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual Response<DataMigrationServiceTaskResource> Update(DataMigrationProjectTaskData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataMigrationServiceTaskTasksClientDiagnostics.CreateScope("DataMigrationServiceTaskResource.Update");
            scope.Start();
            try
            {
                var response = _dataMigrationServiceTaskTasksRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                return Response.FromValue(new DataMigrationServiceTaskResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The tasks resource is a nested, proxy-only resource representing work performed by a DMS (classic) instance. This method cancels a task if it's currently queued or running.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.DataMigration/services/{serviceName}/projects/{projectName}/tasks/{taskName}/cancel</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tasks_Cancel</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataMigrationServiceTaskResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DataMigrationServiceTaskResource>> CancelAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _dataMigrationServiceTaskTasksClientDiagnostics.CreateScope("DataMigrationServiceTaskResource.Cancel");
            scope.Start();
            try
            {
                var response = await _dataMigrationServiceTaskTasksRestClient.CancelAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new DataMigrationServiceTaskResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The tasks resource is a nested, proxy-only resource representing work performed by a DMS (classic) instance. This method cancels a task if it's currently queued or running.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.DataMigration/services/{serviceName}/projects/{projectName}/tasks/{taskName}/cancel</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tasks_Cancel</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataMigrationServiceTaskResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DataMigrationServiceTaskResource> Cancel(CancellationToken cancellationToken = default)
        {
            using var scope = _dataMigrationServiceTaskTasksClientDiagnostics.CreateScope("DataMigrationServiceTaskResource.Cancel");
            scope.Start();
            try
            {
                var response = _dataMigrationServiceTaskTasksRestClient.Cancel(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new DataMigrationServiceTaskResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The tasks resource is a nested, proxy-only resource representing work performed by a DMS (classic) instance. This method executes a command on a running task.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.DataMigration/services/{serviceName}/projects/{projectName}/tasks/{taskName}/command</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tasks_Command</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataMigrationServiceTaskResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataMigrationCommandProperties"> Command to execute. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataMigrationCommandProperties"/> is null. </exception>
        public virtual async Task<Response<DataMigrationCommandProperties>> CommandAsync(DataMigrationCommandProperties dataMigrationCommandProperties, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(dataMigrationCommandProperties, nameof(dataMigrationCommandProperties));

            using var scope = _dataMigrationServiceTaskTasksClientDiagnostics.CreateScope("DataMigrationServiceTaskResource.Command");
            scope.Start();
            try
            {
                var response = await _dataMigrationServiceTaskTasksRestClient.CommandAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, dataMigrationCommandProperties, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The tasks resource is a nested, proxy-only resource representing work performed by a DMS (classic) instance. This method executes a command on a running task.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.DataMigration/services/{serviceName}/projects/{projectName}/tasks/{taskName}/command</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tasks_Command</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataMigrationServiceTaskResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataMigrationCommandProperties"> Command to execute. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataMigrationCommandProperties"/> is null. </exception>
        public virtual Response<DataMigrationCommandProperties> Command(DataMigrationCommandProperties dataMigrationCommandProperties, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(dataMigrationCommandProperties, nameof(dataMigrationCommandProperties));

            using var scope = _dataMigrationServiceTaskTasksClientDiagnostics.CreateScope("DataMigrationServiceTaskResource.Command");
            scope.Start();
            try
            {
                var response = _dataMigrationServiceTaskTasksRestClient.Command(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, dataMigrationCommandProperties, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="ResourceGroupLongTermRetentionManagedInstanceBackupResource"/> and their operations.
    /// Each <see cref="ResourceGroupLongTermRetentionManagedInstanceBackupResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="ResourceGroupLongTermRetentionManagedInstanceBackupCollection"/> instance call the GetResourceGroupLongTermRetentionManagedInstanceBackups method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class ResourceGroupLongTermRetentionManagedInstanceBackupCollection : ArmCollection, IEnumerable<ResourceGroupLongTermRetentionManagedInstanceBackupResource>, IAsyncEnumerable<ResourceGroupLongTermRetentionManagedInstanceBackupResource>
    {
        private readonly ClientDiagnostics _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics;
        private readonly LongTermRetentionManagedInstanceBackupsRestOperations _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient;
        private readonly AzureLocation _locationName;
        private readonly string _managedInstanceName;
        private readonly string _databaseName;

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupLongTermRetentionManagedInstanceBackupCollection"/> class for mocking. </summary>
        protected ResourceGroupLongTermRetentionManagedInstanceBackupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupLongTermRetentionManagedInstanceBackupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="locationName"> The location of the database. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the managed database. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managedInstanceName"/> or <paramref name="databaseName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="managedInstanceName"/> or <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        internal ResourceGroupLongTermRetentionManagedInstanceBackupCollection(ArmClient client, ResourceIdentifier id, AzureLocation locationName, string managedInstanceName, string databaseName) : base(client, id)
        {
            _locationName = locationName;
            _managedInstanceName = managedInstanceName;
            _databaseName = databaseName;
            _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceGroupLongTermRetentionManagedInstanceBackupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceGroupLongTermRetentionManagedInstanceBackupResource.ResourceType, out string resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsApiVersion);
            _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient = new LongTermRetentionManagedInstanceBackupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a long term retention backup for a managed database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups/{backupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LongTermRetentionManagedInstanceBackups_GetByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceGroupLongTermRetentionManagedInstanceBackupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual async Task<Response<ResourceGroupLongTermRetentionManagedInstanceBackupResource>> GetAsync(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionManagedInstanceBackupCollection.Get");
            scope.Start();
            try
            {
                var response = await _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient.GetByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName), _managedInstanceName, _databaseName, backupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceGroupLongTermRetentionManagedInstanceBackupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a long term retention backup for a managed database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups/{backupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LongTermRetentionManagedInstanceBackups_GetByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceGroupLongTermRetentionManagedInstanceBackupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual Response<ResourceGroupLongTermRetentionManagedInstanceBackupResource> Get(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionManagedInstanceBackupCollection.Get");
            scope.Start();
            try
            {
                var response = _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient.GetByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName), _managedInstanceName, _databaseName, backupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceGroupLongTermRetentionManagedInstanceBackupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all long term retention backups for a managed database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LongTermRetentionManagedInstanceBackups_ListByResourceGroupDatabase</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceGroupLongTermRetentionManagedInstanceBackupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="onlyLatestPerDatabase"> Whether or not to only get the latest backup for each database. </param>
        /// <param name="databaseState"> Whether to query against just live databases, just deleted databases, or all databases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceGroupLongTermRetentionManagedInstanceBackupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceGroupLongTermRetentionManagedInstanceBackupResource> GetAllAsync(bool? onlyLatestPerDatabase = null, SqlDatabaseState? databaseState = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient.CreateListByResourceGroupDatabaseRequest(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName), _managedInstanceName, _databaseName, onlyLatestPerDatabase, databaseState);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient.CreateListByResourceGroupDatabaseNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName), _managedInstanceName, _databaseName, onlyLatestPerDatabase, databaseState);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ResourceGroupLongTermRetentionManagedInstanceBackupResource(Client, ManagedInstanceLongTermRetentionBackupData.DeserializeManagedInstanceLongTermRetentionBackupData(e)), _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics, Pipeline, "ResourceGroupLongTermRetentionManagedInstanceBackupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all long term retention backups for a managed database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LongTermRetentionManagedInstanceBackups_ListByResourceGroupDatabase</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceGroupLongTermRetentionManagedInstanceBackupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="onlyLatestPerDatabase"> Whether or not to only get the latest backup for each database. </param>
        /// <param name="databaseState"> Whether to query against just live databases, just deleted databases, or all databases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceGroupLongTermRetentionManagedInstanceBackupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceGroupLongTermRetentionManagedInstanceBackupResource> GetAll(bool? onlyLatestPerDatabase = null, SqlDatabaseState? databaseState = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient.CreateListByResourceGroupDatabaseRequest(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName), _managedInstanceName, _databaseName, onlyLatestPerDatabase, databaseState);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient.CreateListByResourceGroupDatabaseNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName), _managedInstanceName, _databaseName, onlyLatestPerDatabase, databaseState);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ResourceGroupLongTermRetentionManagedInstanceBackupResource(Client, ManagedInstanceLongTermRetentionBackupData.DeserializeManagedInstanceLongTermRetentionBackupData(e)), _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics, Pipeline, "ResourceGroupLongTermRetentionManagedInstanceBackupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups/{backupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LongTermRetentionManagedInstanceBackups_GetByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceGroupLongTermRetentionManagedInstanceBackupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionManagedInstanceBackupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient.GetByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName), _managedInstanceName, _databaseName, backupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups/{backupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LongTermRetentionManagedInstanceBackups_GetByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceGroupLongTermRetentionManagedInstanceBackupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual Response<bool> Exists(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionManagedInstanceBackupCollection.Exists");
            scope.Start();
            try
            {
                var response = _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient.GetByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName), _managedInstanceName, _databaseName, backupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups/{backupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LongTermRetentionManagedInstanceBackups_GetByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceGroupLongTermRetentionManagedInstanceBackupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual async Task<NullableResponse<ResourceGroupLongTermRetentionManagedInstanceBackupResource>> GetIfExistsAsync(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionManagedInstanceBackupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient.GetByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName), _managedInstanceName, _databaseName, backupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ResourceGroupLongTermRetentionManagedInstanceBackupResource>(response.GetRawResponse());
                return Response.FromValue(new ResourceGroupLongTermRetentionManagedInstanceBackupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups/{backupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LongTermRetentionManagedInstanceBackups_GetByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceGroupLongTermRetentionManagedInstanceBackupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual NullableResponse<ResourceGroupLongTermRetentionManagedInstanceBackupResource> GetIfExists(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionManagedInstanceBackupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient.GetByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName), _managedInstanceName, _databaseName, backupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ResourceGroupLongTermRetentionManagedInstanceBackupResource>(response.GetRawResponse());
                return Response.FromValue(new ResourceGroupLongTermRetentionManagedInstanceBackupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ResourceGroupLongTermRetentionManagedInstanceBackupResource> IEnumerable<ResourceGroupLongTermRetentionManagedInstanceBackupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ResourceGroupLongTermRetentionManagedInstanceBackupResource> IAsyncEnumerable<ResourceGroupLongTermRetentionManagedInstanceBackupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.AppConfiguration;

/// <summary>
/// AppConfigurationPrivateEndpointConnection.
/// </summary>
public partial class AppConfigurationPrivateEndpointConnection : ProvisionableResource
{
    /// <summary>
    /// Private endpoint connection name.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// A collection of information about the state of the connection between
    /// service consumer and provider.
    /// </summary>
    public BicepValue<AppConfigurationPrivateLinkServiceConnectionState> ConnectionState { get => _connectionState; set => _connectionState.Assign(value); }
    private readonly BicepValue<AppConfigurationPrivateLinkServiceConnectionState> _connectionState;

    /// <summary>
    /// Gets or sets Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> PrivateEndpointId { get => _privateEndpointId; set => _privateEndpointId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _privateEndpointId;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// The provisioning status of the private endpoint connection.
    /// </summary>
    public BicepValue<AppConfigurationProvisioningState> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<AppConfigurationProvisioningState> _provisioningState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent AppConfigurationStore.
    /// </summary>
    public AppConfigurationStore? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<AppConfigurationStore> _parent;

    /// <summary>
    /// Creates a new AppConfigurationPrivateEndpointConnection.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the
    /// AppConfigurationPrivateEndpointConnection resource.  This can be used
    /// to refer to the resource in expressions, but is not the Azure name of
    /// the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the AppConfigurationPrivateEndpointConnection.</param>
    public AppConfigurationPrivateEndpointConnection(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.AppConfiguration/configurationStores/privateEndpointConnections", resourceVersion ?? "2024-05-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _connectionState = BicepValue<AppConfigurationPrivateLinkServiceConnectionState>.DefineProperty(this, "ConnectionState", ["properties", "privateLinkServiceConnectionState"]);
        _privateEndpointId = BicepValue<ResourceIdentifier>.DefineProperty(this, "PrivateEndpointId", ["properties", "privateEndpoint", "id"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _provisioningState = BicepValue<AppConfigurationProvisioningState>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<AppConfigurationStore>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported AppConfigurationPrivateEndpointConnection resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-05-01.
        /// </summary>
        public static readonly string V2024_05_01 = "2024-05-01";

        /// <summary>
        /// 2023-03-01.
        /// </summary>
        public static readonly string V2023_03_01 = "2023-03-01";

        /// <summary>
        /// 2022-05-01.
        /// </summary>
        public static readonly string V2022_05_01 = "2022-05-01";

        /// <summary>
        /// 2020-06-01.
        /// </summary>
        public static readonly string V2020_06_01 = "2020-06-01";

        /// <summary>
        /// 2019-10-01.
        /// </summary>
        public static readonly string V2019_10_01 = "2019-10-01";
    }

    /// <summary>
    /// Creates a reference to an existing
    /// AppConfigurationPrivateEndpointConnection.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the
    /// AppConfigurationPrivateEndpointConnection resource.  This can be used
    /// to refer to the resource in expressions, but is not the Azure name of
    /// the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the AppConfigurationPrivateEndpointConnection.</param>
    /// <returns>The existing AppConfigurationPrivateEndpointConnection resource.</returns>
    public static AppConfigurationPrivateEndpointConnection FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// Storage for deployed package used by the function app.
/// </summary>
public partial class FunctionAppStorage : ProvisionableConstruct
{
    /// <summary>
    /// Property to select Azure Storage type. Available options: blobContainer.
    /// </summary>
    public BicepValue<FunctionAppStorageType> StorageType { get => _storageType; set => _storageType.Assign(value); }
    private readonly BicepValue<FunctionAppStorageType> _storageType;

    /// <summary>
    /// Property to set the URL for the selected Azure Storage type. Example:
    /// For blobContainer, the value could be
    /// https://&lt;storageAccountName&gt;.blob.core.windows.net/&lt;containerName&gt;.
    /// </summary>
    public BicepValue<Uri> Value { get => _value; set => _value.Assign(value); }
    private readonly BicepValue<Uri> _value;

    /// <summary>
    /// Authentication method to access the storage account for deployment.
    /// </summary>
    public BicepValue<FunctionAppStorageAuthentication> Authentication { get => _authentication; set => _authentication.Assign(value); }
    private readonly BicepValue<FunctionAppStorageAuthentication> _authentication;

    /// <summary>
    /// Creates a new FunctionAppStorage.
    /// </summary>
    public FunctionAppStorage()
    {
        _storageType = BicepValue<FunctionAppStorageType>.DefineProperty(this, "StorageType", ["type"]);
        _value = BicepValue<Uri>.DefineProperty(this, "Value", ["value"]);
        _authentication = BicepValue<FunctionAppStorageAuthentication>.DefineProperty(this, "Authentication", ["authentication"]);
    }
}

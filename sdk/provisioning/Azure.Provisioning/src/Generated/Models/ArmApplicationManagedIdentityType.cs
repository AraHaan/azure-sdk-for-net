// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using System.Runtime.Serialization;

namespace Azure.Provisioning.Resources;

/// <summary>
/// The identity type.
/// </summary>
public enum ArmApplicationManagedIdentityType
{
    /// <summary>
    /// None.
    /// </summary>
    None,

    /// <summary>
    /// SystemAssigned.
    /// </summary>
    SystemAssigned,

    /// <summary>
    /// UserAssigned.
    /// </summary>
    UserAssigned,

    /// <summary>
    /// SystemAssigned, UserAssigned.
    /// </summary>
    [DataMember(Name = "SystemAssigned, UserAssigned")]
    SystemAssignedUserAssigned,
}

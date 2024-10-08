// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using System.Runtime.Serialization;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// Sticky Session Affinity.
/// </summary>
public enum StickySessionAffinity
{
    /// <summary>
    /// sticky.
    /// </summary>
    [DataMember(Name = "sticky")]
    Sticky,

    /// <summary>
    /// none.
    /// </summary>
    [DataMember(Name = "none")]
    None,
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using System.Runtime.Serialization;

namespace Azure.Provisioning.KeyVault;

/// <summary>
/// The IdentityAccessStoragePermission.
/// </summary>
public enum IdentityAccessStoragePermission
{
    /// <summary>
    /// all.
    /// </summary>
    [DataMember(Name = "all")]
    All,

    /// <summary>
    /// get.
    /// </summary>
    [DataMember(Name = "get")]
    Get,

    /// <summary>
    /// list.
    /// </summary>
    [DataMember(Name = "list")]
    List,

    /// <summary>
    /// delete.
    /// </summary>
    [DataMember(Name = "delete")]
    Delete,

    /// <summary>
    /// set.
    /// </summary>
    [DataMember(Name = "set")]
    Set,

    /// <summary>
    /// update.
    /// </summary>
    [DataMember(Name = "update")]
    Update,

    /// <summary>
    /// regeneratekey.
    /// </summary>
    [DataMember(Name = "regeneratekey")]
    RegenerateKey,

    /// <summary>
    /// recover.
    /// </summary>
    [DataMember(Name = "recover")]
    Recover,

    /// <summary>
    /// purge.
    /// </summary>
    [DataMember(Name = "purge")]
    Purge,

    /// <summary>
    /// backup.
    /// </summary>
    [DataMember(Name = "backup")]
    Backup,

    /// <summary>
    /// restore.
    /// </summary>
    [DataMember(Name = "restore")]
    Restore,

    /// <summary>
    /// setsas.
    /// </summary>
    [DataMember(Name = "setsas")]
    SetSas,

    /// <summary>
    /// listsas.
    /// </summary>
    [DataMember(Name = "listsas")]
    ListSas,

    /// <summary>
    /// getsas.
    /// </summary>
    [DataMember(Name = "getsas")]
    GetSas,

    /// <summary>
    /// deletesas.
    /// </summary>
    [DataMember(Name = "deletesas")]
    DeleteSas,
}

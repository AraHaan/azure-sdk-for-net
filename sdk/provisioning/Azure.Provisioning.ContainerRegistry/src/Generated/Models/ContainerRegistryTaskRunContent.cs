// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerRegistry;

/// <summary>
/// The parameters for a task run request.
/// </summary>
public partial class ContainerRegistryTaskRunContent : ContainerRegistryRunContent
{
    /// <summary>
    /// The resource ID of task against which run has to be queued.
    /// </summary>
    public BicepValue<ResourceIdentifier> TaskId { get => _taskId; set => _taskId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _taskId;

    /// <summary>
    /// Set of overridable parameters that can be passed when running a Task.
    /// </summary>
    public BicepValue<ContainerRegistryOverrideTaskStepProperties> OverrideTaskStepProperties { get => _overrideTaskStepProperties; set => _overrideTaskStepProperties.Assign(value); }
    private readonly BicepValue<ContainerRegistryOverrideTaskStepProperties> _overrideTaskStepProperties;

    /// <summary>
    /// Creates a new ContainerRegistryTaskRunContent.
    /// </summary>
    public ContainerRegistryTaskRunContent() : base()
    {
        BicepValue<string>.DefineProperty(this, "type", ["type"], defaultValue: "TaskRunRequest");
        _taskId = BicepValue<ResourceIdentifier>.DefineProperty(this, "TaskId", ["taskId"]);
        _overrideTaskStepProperties = BicepValue<ContainerRegistryOverrideTaskStepProperties>.DefineProperty(this, "OverrideTaskStepProperties", ["overrideTaskStepProperties"]);
    }
}

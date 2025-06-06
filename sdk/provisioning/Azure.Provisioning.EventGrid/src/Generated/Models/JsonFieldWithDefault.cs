// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// This is used to express the source of an input schema mapping for a single
/// target field             in the Event Grid Event schema. This is currently
/// used in the mappings for the &apos;subject&apos;,
/// &apos;eventtype&apos; and &apos;dataversion&apos; properties.
/// This represents a field in the input event schema             along with a
/// default value to be used, and at least one of these two properties should
/// be provided.
/// </summary>
public partial class JsonFieldWithDefault : ProvisionableConstruct
{
    /// <summary>
    /// Name of a field in the input event schema that&apos;s to be used as the
    /// source of a mapping.
    /// </summary>
    public BicepValue<string> SourceField 
    {
        get { Initialize(); return _sourceField!; }
        set { Initialize(); _sourceField!.Assign(value); }
    }
    private BicepValue<string>? _sourceField;

    /// <summary>
    /// The default value to be used for mapping when a SourceField is not
    /// provided or if there&apos;s no property with the specified name in the
    /// published JSON event payload.
    /// </summary>
    public BicepValue<string> DefaultValue 
    {
        get { Initialize(); return _defaultValue!; }
        set { Initialize(); _defaultValue!.Assign(value); }
    }
    private BicepValue<string>? _defaultValue;

    /// <summary>
    /// Creates a new JsonFieldWithDefault.
    /// </summary>
    public JsonFieldWithDefault()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of JsonFieldWithDefault.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _sourceField = DefineProperty<string>("SourceField", ["sourceField"]);
        _defaultValue = DefineProperty<string>("DefaultValue", ["defaultValue"]);
    }
}

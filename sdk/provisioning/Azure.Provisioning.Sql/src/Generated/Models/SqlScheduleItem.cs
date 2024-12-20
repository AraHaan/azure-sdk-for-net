// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// Schedule info describing when the server should be started or stopped.
/// </summary>
public partial class SqlScheduleItem : ProvisionableConstruct
{
    /// <summary>
    /// Start day.
    /// </summary>
    public BicepValue<SqlDayOfWeek> StartDay 
    {
        get { Initialize(); return _startDay!; }
        set { Initialize(); _startDay!.Assign(value); }
    }
    private BicepValue<SqlDayOfWeek>? _startDay;

    /// <summary>
    /// Start time.
    /// </summary>
    public BicepValue<string> StartTime 
    {
        get { Initialize(); return _startTime!; }
        set { Initialize(); _startTime!.Assign(value); }
    }
    private BicepValue<string>? _startTime;

    /// <summary>
    /// Stop day.
    /// </summary>
    public BicepValue<SqlDayOfWeek> StopDay 
    {
        get { Initialize(); return _stopDay!; }
        set { Initialize(); _stopDay!.Assign(value); }
    }
    private BicepValue<SqlDayOfWeek>? _stopDay;

    /// <summary>
    /// Stop time.
    /// </summary>
    public BicepValue<string> StopTime 
    {
        get { Initialize(); return _stopTime!; }
        set { Initialize(); _stopTime!.Assign(value); }
    }
    private BicepValue<string>? _stopTime;

    /// <summary>
    /// Creates a new SqlScheduleItem.
    /// </summary>
    public SqlScheduleItem()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of SqlScheduleItem.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _startDay = DefineProperty<SqlDayOfWeek>("StartDay", ["startDay"]);
        _startTime = DefineProperty<string>("StartTime", ["startTime"]);
        _stopDay = DefineProperty<SqlDayOfWeek>("StopDay", ["stopDay"]);
        _stopTime = DefineProperty<string>("StopTime", ["stopTime"]);
    }
}

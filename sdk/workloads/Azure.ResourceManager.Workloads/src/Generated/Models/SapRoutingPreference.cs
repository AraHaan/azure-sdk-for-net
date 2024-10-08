// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Sets the routing preference of the SAP monitor. By default only RFC1918 traffic is routed to the customer VNET. </summary>
    public readonly partial struct SapRoutingPreference : IEquatable<SapRoutingPreference>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SapRoutingPreference"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SapRoutingPreference(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "Default";
        private const string RouteAllValue = "RouteAll";

        /// <summary> Default. </summary>
        public static SapRoutingPreference Default { get; } = new SapRoutingPreference(DefaultValue);
        /// <summary> RouteAll. </summary>
        public static SapRoutingPreference RouteAll { get; } = new SapRoutingPreference(RouteAllValue);
        /// <summary> Determines if two <see cref="SapRoutingPreference"/> values are the same. </summary>
        public static bool operator ==(SapRoutingPreference left, SapRoutingPreference right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SapRoutingPreference"/> values are not the same. </summary>
        public static bool operator !=(SapRoutingPreference left, SapRoutingPreference right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SapRoutingPreference"/>. </summary>
        public static implicit operator SapRoutingPreference(string value) => new SapRoutingPreference(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SapRoutingPreference other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SapRoutingPreference other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

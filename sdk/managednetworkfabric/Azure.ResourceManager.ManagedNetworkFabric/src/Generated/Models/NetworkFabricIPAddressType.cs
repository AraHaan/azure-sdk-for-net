// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> IP Address type. </summary>
    public readonly partial struct NetworkFabricIPAddressType : IEquatable<NetworkFabricIPAddressType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NetworkFabricIPAddressType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NetworkFabricIPAddressType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IPv4Value = "IPv4";
        private const string IPv6Value = "IPv6";

        /// <summary> IPv4. </summary>
        public static NetworkFabricIPAddressType IPv4 { get; } = new NetworkFabricIPAddressType(IPv4Value);
        /// <summary> IPv6. </summary>
        public static NetworkFabricIPAddressType IPv6 { get; } = new NetworkFabricIPAddressType(IPv6Value);
        /// <summary> Determines if two <see cref="NetworkFabricIPAddressType"/> values are the same. </summary>
        public static bool operator ==(NetworkFabricIPAddressType left, NetworkFabricIPAddressType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NetworkFabricIPAddressType"/> values are not the same. </summary>
        public static bool operator !=(NetworkFabricIPAddressType left, NetworkFabricIPAddressType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="NetworkFabricIPAddressType"/>. </summary>
        public static implicit operator NetworkFabricIPAddressType(string value) => new NetworkFabricIPAddressType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetworkFabricIPAddressType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetworkFabricIPAddressType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

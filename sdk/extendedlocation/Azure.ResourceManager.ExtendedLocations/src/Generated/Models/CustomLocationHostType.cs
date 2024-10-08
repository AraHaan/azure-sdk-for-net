// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ExtendedLocations.Models
{
    /// <summary> Type of host the Custom Locations is referencing (Kubernetes, etc...). </summary>
    public readonly partial struct CustomLocationHostType : IEquatable<CustomLocationHostType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CustomLocationHostType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CustomLocationHostType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string KubernetesValue = "Kubernetes";

        /// <summary> Kubernetes. </summary>
        public static CustomLocationHostType Kubernetes { get; } = new CustomLocationHostType(KubernetesValue);
        /// <summary> Determines if two <see cref="CustomLocationHostType"/> values are the same. </summary>
        public static bool operator ==(CustomLocationHostType left, CustomLocationHostType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CustomLocationHostType"/> values are not the same. </summary>
        public static bool operator !=(CustomLocationHostType left, CustomLocationHostType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="CustomLocationHostType"/>. </summary>
        public static implicit operator CustomLocationHostType(string value) => new CustomLocationHostType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CustomLocationHostType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CustomLocationHostType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

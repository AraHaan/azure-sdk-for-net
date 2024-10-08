// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Unmasked IP address logging status. </summary>
    public readonly partial struct UnmaskedIPLoggingStatus : IEquatable<UnmaskedIPLoggingStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="UnmaskedIPLoggingStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public UnmaskedIPLoggingStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DisabledValue = "Disabled";
        private const string EnabledValue = "Enabled";

        /// <summary> Unmasked IP logging is disabled. </summary>
        public static UnmaskedIPLoggingStatus Disabled { get; } = new UnmaskedIPLoggingStatus(DisabledValue);
        /// <summary> Unmasked IP logging is enabled. </summary>
        public static UnmaskedIPLoggingStatus Enabled { get; } = new UnmaskedIPLoggingStatus(EnabledValue);
        /// <summary> Determines if two <see cref="UnmaskedIPLoggingStatus"/> values are the same. </summary>
        public static bool operator ==(UnmaskedIPLoggingStatus left, UnmaskedIPLoggingStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="UnmaskedIPLoggingStatus"/> values are not the same. </summary>
        public static bool operator !=(UnmaskedIPLoggingStatus left, UnmaskedIPLoggingStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="UnmaskedIPLoggingStatus"/>. </summary>
        public static implicit operator UnmaskedIPLoggingStatus(string value) => new UnmaskedIPLoggingStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is UnmaskedIPLoggingStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(UnmaskedIPLoggingStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

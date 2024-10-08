// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The identity type. </summary>
    public readonly partial struct DatabaseIdentityType : IEquatable<DatabaseIdentityType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DatabaseIdentityType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DatabaseIdentityType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string UserAssignedValue = "UserAssigned";

        /// <summary> None. </summary>
        public static DatabaseIdentityType None { get; } = new DatabaseIdentityType(NoneValue);
        /// <summary> UserAssigned. </summary>
        public static DatabaseIdentityType UserAssigned { get; } = new DatabaseIdentityType(UserAssignedValue);
        /// <summary> Determines if two <see cref="DatabaseIdentityType"/> values are the same. </summary>
        public static bool operator ==(DatabaseIdentityType left, DatabaseIdentityType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DatabaseIdentityType"/> values are not the same. </summary>
        public static bool operator !=(DatabaseIdentityType left, DatabaseIdentityType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DatabaseIdentityType"/>. </summary>
        public static implicit operator DatabaseIdentityType(string value) => new DatabaseIdentityType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DatabaseIdentityType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DatabaseIdentityType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

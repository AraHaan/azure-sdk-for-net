// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Specifies the internal format of instance databases specific to the SQL engine version. </summary>
    public readonly partial struct ManagedInstanceDatabaseFormat : IEquatable<ManagedInstanceDatabaseFormat>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ManagedInstanceDatabaseFormat"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ManagedInstanceDatabaseFormat(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AlwaysUpToDateValue = "AlwaysUpToDate";
        private const string SqlServer2022Value = "SQLServer2022";
        private const string SqlServer2025Value = "SQLServer2025";

        /// <summary> AlwaysUpToDate. </summary>
        public static ManagedInstanceDatabaseFormat AlwaysUpToDate { get; } = new ManagedInstanceDatabaseFormat(AlwaysUpToDateValue);
        /// <summary> SQLServer2022. </summary>
        public static ManagedInstanceDatabaseFormat SqlServer2022 { get; } = new ManagedInstanceDatabaseFormat(SqlServer2022Value);
        /// <summary> SQLServer2025. </summary>
        public static ManagedInstanceDatabaseFormat SqlServer2025 { get; } = new ManagedInstanceDatabaseFormat(SqlServer2025Value);
        /// <summary> Determines if two <see cref="ManagedInstanceDatabaseFormat"/> values are the same. </summary>
        public static bool operator ==(ManagedInstanceDatabaseFormat left, ManagedInstanceDatabaseFormat right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ManagedInstanceDatabaseFormat"/> values are not the same. </summary>
        public static bool operator !=(ManagedInstanceDatabaseFormat left, ManagedInstanceDatabaseFormat right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ManagedInstanceDatabaseFormat"/>. </summary>
        public static implicit operator ManagedInstanceDatabaseFormat(string value) => new ManagedInstanceDatabaseFormat(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ManagedInstanceDatabaseFormat other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ManagedInstanceDatabaseFormat other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

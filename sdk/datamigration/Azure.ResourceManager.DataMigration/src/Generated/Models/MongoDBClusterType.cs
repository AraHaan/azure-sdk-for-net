// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> The type of data source. </summary>
    public readonly partial struct MongoDBClusterType : IEquatable<MongoDBClusterType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MongoDBClusterType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MongoDBClusterType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BlobContainerValue = "BlobContainer";
        private const string CosmosDBValue = "CosmosDb";
        private const string MongoDBValue = "MongoDb";

        /// <summary> BlobContainer. </summary>
        public static MongoDBClusterType BlobContainer { get; } = new MongoDBClusterType(BlobContainerValue);
        /// <summary> CosmosDb. </summary>
        public static MongoDBClusterType CosmosDB { get; } = new MongoDBClusterType(CosmosDBValue);
        /// <summary> MongoDb. </summary>
        public static MongoDBClusterType MongoDB { get; } = new MongoDBClusterType(MongoDBValue);
        /// <summary> Determines if two <see cref="MongoDBClusterType"/> values are the same. </summary>
        public static bool operator ==(MongoDBClusterType left, MongoDBClusterType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MongoDBClusterType"/> values are not the same. </summary>
        public static bool operator !=(MongoDBClusterType left, MongoDBClusterType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MongoDBClusterType"/>. </summary>
        public static implicit operator MongoDBClusterType(string value) => new MongoDBClusterType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MongoDBClusterType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MongoDBClusterType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

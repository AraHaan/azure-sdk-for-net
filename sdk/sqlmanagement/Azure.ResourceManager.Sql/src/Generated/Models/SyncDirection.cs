// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Sync direction of the sync member. </summary>
    public readonly partial struct SyncDirection : IEquatable<SyncDirection>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SyncDirection"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SyncDirection(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BidirectionalValue = "Bidirectional";
        private const string OneWayMemberToHubValue = "OneWayMemberToHub";
        private const string OneWayHubToMemberValue = "OneWayHubToMember";

        /// <summary> Bidirectional. </summary>
        public static SyncDirection Bidirectional { get; } = new SyncDirection(BidirectionalValue);
        /// <summary> OneWayMemberToHub. </summary>
        public static SyncDirection OneWayMemberToHub { get; } = new SyncDirection(OneWayMemberToHubValue);
        /// <summary> OneWayHubToMember. </summary>
        public static SyncDirection OneWayHubToMember { get; } = new SyncDirection(OneWayHubToMemberValue);
        /// <summary> Determines if two <see cref="SyncDirection"/> values are the same. </summary>
        public static bool operator ==(SyncDirection left, SyncDirection right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SyncDirection"/> values are not the same. </summary>
        public static bool operator !=(SyncDirection left, SyncDirection right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SyncDirection"/>. </summary>
        public static implicit operator SyncDirection(string value) => new SyncDirection(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SyncDirection other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SyncDirection other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

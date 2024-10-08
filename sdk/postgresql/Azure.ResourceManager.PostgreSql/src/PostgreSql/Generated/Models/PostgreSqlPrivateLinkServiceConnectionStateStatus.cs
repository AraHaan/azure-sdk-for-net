// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PostgreSql.Models
{
    /// <summary> The private link service connection status. </summary>
    public readonly partial struct PostgreSqlPrivateLinkServiceConnectionStateStatus : IEquatable<PostgreSqlPrivateLinkServiceConnectionStateStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlPrivateLinkServiceConnectionStateStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PostgreSqlPrivateLinkServiceConnectionStateStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ApprovedValue = "Approved";
        private const string PendingValue = "Pending";
        private const string RejectedValue = "Rejected";
        private const string DisconnectedValue = "Disconnected";

        /// <summary> Approved. </summary>
        public static PostgreSqlPrivateLinkServiceConnectionStateStatus Approved { get; } = new PostgreSqlPrivateLinkServiceConnectionStateStatus(ApprovedValue);
        /// <summary> Pending. </summary>
        public static PostgreSqlPrivateLinkServiceConnectionStateStatus Pending { get; } = new PostgreSqlPrivateLinkServiceConnectionStateStatus(PendingValue);
        /// <summary> Rejected. </summary>
        public static PostgreSqlPrivateLinkServiceConnectionStateStatus Rejected { get; } = new PostgreSqlPrivateLinkServiceConnectionStateStatus(RejectedValue);
        /// <summary> Disconnected. </summary>
        public static PostgreSqlPrivateLinkServiceConnectionStateStatus Disconnected { get; } = new PostgreSqlPrivateLinkServiceConnectionStateStatus(DisconnectedValue);
        /// <summary> Determines if two <see cref="PostgreSqlPrivateLinkServiceConnectionStateStatus"/> values are the same. </summary>
        public static bool operator ==(PostgreSqlPrivateLinkServiceConnectionStateStatus left, PostgreSqlPrivateLinkServiceConnectionStateStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PostgreSqlPrivateLinkServiceConnectionStateStatus"/> values are not the same. </summary>
        public static bool operator !=(PostgreSqlPrivateLinkServiceConnectionStateStatus left, PostgreSqlPrivateLinkServiceConnectionStateStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="PostgreSqlPrivateLinkServiceConnectionStateStatus"/>. </summary>
        public static implicit operator PostgreSqlPrivateLinkServiceConnectionStateStatus(string value) => new PostgreSqlPrivateLinkServiceConnectionStateStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PostgreSqlPrivateLinkServiceConnectionStateStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PostgreSqlPrivateLinkServiceConnectionStateStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

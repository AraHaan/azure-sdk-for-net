// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> Represents the billing plan in ISO 8601 format. Required only for monthly purchases. </summary>
    public readonly partial struct BillingPlan : IEquatable<BillingPlan>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BillingPlan"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BillingPlan(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string P1MValue = "P1M";

        /// <summary> P1M. </summary>
        public static BillingPlan P1M { get; } = new BillingPlan(P1MValue);
        /// <summary> Determines if two <see cref="BillingPlan"/> values are the same. </summary>
        public static bool operator ==(BillingPlan left, BillingPlan right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BillingPlan"/> values are not the same. </summary>
        public static bool operator !=(BillingPlan left, BillingPlan right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="BillingPlan"/>. </summary>
        public static implicit operator BillingPlan(string value) => new BillingPlan(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BillingPlan other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BillingPlan other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

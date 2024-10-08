// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> The provisioning state of the cluster. </summary>
    public readonly partial struct OperationalInsightsClusterEntityStatus : IEquatable<OperationalInsightsClusterEntityStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OperationalInsightsClusterEntityStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OperationalInsightsClusterEntityStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string DeletingValue = "Deleting";
        private const string ProvisioningAccountValue = "ProvisioningAccount";
        private const string UpdatingValue = "Updating";

        /// <summary> Creating. </summary>
        public static OperationalInsightsClusterEntityStatus Creating { get; } = new OperationalInsightsClusterEntityStatus(CreatingValue);
        /// <summary> Succeeded. </summary>
        public static OperationalInsightsClusterEntityStatus Succeeded { get; } = new OperationalInsightsClusterEntityStatus(SucceededValue);
        /// <summary> Failed. </summary>
        public static OperationalInsightsClusterEntityStatus Failed { get; } = new OperationalInsightsClusterEntityStatus(FailedValue);
        /// <summary> Canceled. </summary>
        public static OperationalInsightsClusterEntityStatus Canceled { get; } = new OperationalInsightsClusterEntityStatus(CanceledValue);
        /// <summary> Deleting. </summary>
        public static OperationalInsightsClusterEntityStatus Deleting { get; } = new OperationalInsightsClusterEntityStatus(DeletingValue);
        /// <summary> ProvisioningAccount. </summary>
        public static OperationalInsightsClusterEntityStatus ProvisioningAccount { get; } = new OperationalInsightsClusterEntityStatus(ProvisioningAccountValue);
        /// <summary> Updating. </summary>
        public static OperationalInsightsClusterEntityStatus Updating { get; } = new OperationalInsightsClusterEntityStatus(UpdatingValue);
        /// <summary> Determines if two <see cref="OperationalInsightsClusterEntityStatus"/> values are the same. </summary>
        public static bool operator ==(OperationalInsightsClusterEntityStatus left, OperationalInsightsClusterEntityStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OperationalInsightsClusterEntityStatus"/> values are not the same. </summary>
        public static bool operator !=(OperationalInsightsClusterEntityStatus left, OperationalInsightsClusterEntityStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="OperationalInsightsClusterEntityStatus"/>. </summary>
        public static implicit operator OperationalInsightsClusterEntityStatus(string value) => new OperationalInsightsClusterEntityStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OperationalInsightsClusterEntityStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OperationalInsightsClusterEntityStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

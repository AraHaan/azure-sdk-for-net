// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The current deployment state of schedule. </summary>
    public readonly partial struct MachineLearningComputeProvisioningStatus : IEquatable<MachineLearningComputeProvisioningStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MachineLearningComputeProvisioningStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MachineLearningComputeProvisioningStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CompletedValue = "Completed";
        private const string ProvisioningValue = "Provisioning";
        private const string FailedValue = "Failed";

        /// <summary> Completed. </summary>
        public static MachineLearningComputeProvisioningStatus Completed { get; } = new MachineLearningComputeProvisioningStatus(CompletedValue);
        /// <summary> Provisioning. </summary>
        public static MachineLearningComputeProvisioningStatus Provisioning { get; } = new MachineLearningComputeProvisioningStatus(ProvisioningValue);
        /// <summary> Failed. </summary>
        public static MachineLearningComputeProvisioningStatus Failed { get; } = new MachineLearningComputeProvisioningStatus(FailedValue);
        /// <summary> Determines if two <see cref="MachineLearningComputeProvisioningStatus"/> values are the same. </summary>
        public static bool operator ==(MachineLearningComputeProvisioningStatus left, MachineLearningComputeProvisioningStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MachineLearningComputeProvisioningStatus"/> values are not the same. </summary>
        public static bool operator !=(MachineLearningComputeProvisioningStatus left, MachineLearningComputeProvisioningStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MachineLearningComputeProvisioningStatus"/>. </summary>
        public static implicit operator MachineLearningComputeProvisioningStatus(string value) => new MachineLearningComputeProvisioningStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MachineLearningComputeProvisioningStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MachineLearningComputeProvisioningStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Attestation.Models
{
    /// <summary> The current provisioning state. </summary>
    public readonly partial struct AttestationPrivateEndpointConnectionProvisioningState : IEquatable<AttestationPrivateEndpointConnectionProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AttestationPrivateEndpointConnectionProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AttestationPrivateEndpointConnectionProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string CreatingValue = "Creating";
        private const string DeletingValue = "Deleting";
        private const string FailedValue = "Failed";

        /// <summary> Succeeded. </summary>
        public static AttestationPrivateEndpointConnectionProvisioningState Succeeded { get; } = new AttestationPrivateEndpointConnectionProvisioningState(SucceededValue);
        /// <summary> Creating. </summary>
        public static AttestationPrivateEndpointConnectionProvisioningState Creating { get; } = new AttestationPrivateEndpointConnectionProvisioningState(CreatingValue);
        /// <summary> Deleting. </summary>
        public static AttestationPrivateEndpointConnectionProvisioningState Deleting { get; } = new AttestationPrivateEndpointConnectionProvisioningState(DeletingValue);
        /// <summary> Failed. </summary>
        public static AttestationPrivateEndpointConnectionProvisioningState Failed { get; } = new AttestationPrivateEndpointConnectionProvisioningState(FailedValue);
        /// <summary> Determines if two <see cref="AttestationPrivateEndpointConnectionProvisioningState"/> values are the same. </summary>
        public static bool operator ==(AttestationPrivateEndpointConnectionProvisioningState left, AttestationPrivateEndpointConnectionProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AttestationPrivateEndpointConnectionProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(AttestationPrivateEndpointConnectionProvisioningState left, AttestationPrivateEndpointConnectionProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AttestationPrivateEndpointConnectionProvisioningState"/>. </summary>
        public static implicit operator AttestationPrivateEndpointConnectionProvisioningState(string value) => new AttestationPrivateEndpointConnectionProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AttestationPrivateEndpointConnectionProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AttestationPrivateEndpointConnectionProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

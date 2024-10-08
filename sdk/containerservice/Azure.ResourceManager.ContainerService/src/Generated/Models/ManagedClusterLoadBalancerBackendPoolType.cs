// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> The type of the managed inbound Load Balancer BackendPool. </summary>
    public readonly partial struct ManagedClusterLoadBalancerBackendPoolType : IEquatable<ManagedClusterLoadBalancerBackendPoolType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ManagedClusterLoadBalancerBackendPoolType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ManagedClusterLoadBalancerBackendPoolType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NodeIPConfigurationValue = "NodeIPConfiguration";
        private const string NodeIPValue = "NodeIP";

        /// <summary> The type of the managed inbound Load Balancer BackendPool. https://cloud-provider-azure.sigs.k8s.io/topics/loadbalancer/#configure-load-balancer-backend. </summary>
        public static ManagedClusterLoadBalancerBackendPoolType NodeIPConfiguration { get; } = new ManagedClusterLoadBalancerBackendPoolType(NodeIPConfigurationValue);
        /// <summary> The type of the managed inbound Load Balancer BackendPool. https://cloud-provider-azure.sigs.k8s.io/topics/loadbalancer/#configure-load-balancer-backend. </summary>
        public static ManagedClusterLoadBalancerBackendPoolType NodeIP { get; } = new ManagedClusterLoadBalancerBackendPoolType(NodeIPValue);
        /// <summary> Determines if two <see cref="ManagedClusterLoadBalancerBackendPoolType"/> values are the same. </summary>
        public static bool operator ==(ManagedClusterLoadBalancerBackendPoolType left, ManagedClusterLoadBalancerBackendPoolType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ManagedClusterLoadBalancerBackendPoolType"/> values are not the same. </summary>
        public static bool operator !=(ManagedClusterLoadBalancerBackendPoolType left, ManagedClusterLoadBalancerBackendPoolType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ManagedClusterLoadBalancerBackendPoolType"/>. </summary>
        public static implicit operator ManagedClusterLoadBalancerBackendPoolType(string value) => new ManagedClusterLoadBalancerBackendPoolType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ManagedClusterLoadBalancerBackendPoolType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ManagedClusterLoadBalancerBackendPoolType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

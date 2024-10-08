// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> How ingress should communicate with this app backend service. </summary>
    public readonly partial struct AppBackendProtocol : IEquatable<AppBackendProtocol>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AppBackendProtocol"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AppBackendProtocol(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string GrpcValue = "GRPC";
        private const string DefaultValue = "Default";

        /// <summary> GRPC. </summary>
        public static AppBackendProtocol Grpc { get; } = new AppBackendProtocol(GrpcValue);
        /// <summary> Default. </summary>
        public static AppBackendProtocol Default { get; } = new AppBackendProtocol(DefaultValue);
        /// <summary> Determines if two <see cref="AppBackendProtocol"/> values are the same. </summary>
        public static bool operator ==(AppBackendProtocol left, AppBackendProtocol right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AppBackendProtocol"/> values are not the same. </summary>
        public static bool operator !=(AppBackendProtocol left, AppBackendProtocol right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AppBackendProtocol"/>. </summary>
        public static implicit operator AppBackendProtocol(string value) => new AppBackendProtocol(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AppBackendProtocol other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AppBackendProtocol other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

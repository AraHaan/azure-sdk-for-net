// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The IKE integrity algorithm (IKE phase 2). </summary>
    public readonly partial struct IkeIntegrity : IEquatable<IkeIntegrity>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IkeIntegrity"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IkeIntegrity(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MD5Value = "MD5";
        private const string Sha1Value = "SHA1";
        private const string Sha256Value = "SHA256";
        private const string Sha384Value = "SHA384";
        private const string GcmAes256Value = "GCMAES256";
        private const string GcmAes128Value = "GCMAES128";

        /// <summary> MD5. </summary>
        public static IkeIntegrity MD5 { get; } = new IkeIntegrity(MD5Value);
        /// <summary> SHA1. </summary>
        public static IkeIntegrity Sha1 { get; } = new IkeIntegrity(Sha1Value);
        /// <summary> SHA256. </summary>
        public static IkeIntegrity Sha256 { get; } = new IkeIntegrity(Sha256Value);
        /// <summary> SHA384. </summary>
        public static IkeIntegrity Sha384 { get; } = new IkeIntegrity(Sha384Value);
        /// <summary> GCMAES256. </summary>
        public static IkeIntegrity GcmAes256 { get; } = new IkeIntegrity(GcmAes256Value);
        /// <summary> GCMAES128. </summary>
        public static IkeIntegrity GcmAes128 { get; } = new IkeIntegrity(GcmAes128Value);
        /// <summary> Determines if two <see cref="IkeIntegrity"/> values are the same. </summary>
        public static bool operator ==(IkeIntegrity left, IkeIntegrity right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IkeIntegrity"/> values are not the same. </summary>
        public static bool operator !=(IkeIntegrity left, IkeIntegrity right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="IkeIntegrity"/>. </summary>
        public static implicit operator IkeIntegrity(string value) => new IkeIntegrity(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IkeIntegrity other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IkeIntegrity other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

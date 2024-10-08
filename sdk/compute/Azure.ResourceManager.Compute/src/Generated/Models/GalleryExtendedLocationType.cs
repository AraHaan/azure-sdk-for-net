// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> It is type of the extended location. </summary>
    public readonly partial struct GalleryExtendedLocationType : IEquatable<GalleryExtendedLocationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="GalleryExtendedLocationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public GalleryExtendedLocationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EdgeZoneValue = "EdgeZone";
        private const string UnknownValue = "Unknown";

        /// <summary> EdgeZone. </summary>
        public static GalleryExtendedLocationType EdgeZone { get; } = new GalleryExtendedLocationType(EdgeZoneValue);
        /// <summary> Unknown. </summary>
        public static GalleryExtendedLocationType Unknown { get; } = new GalleryExtendedLocationType(UnknownValue);
        /// <summary> Determines if two <see cref="GalleryExtendedLocationType"/> values are the same. </summary>
        public static bool operator ==(GalleryExtendedLocationType left, GalleryExtendedLocationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="GalleryExtendedLocationType"/> values are not the same. </summary>
        public static bool operator !=(GalleryExtendedLocationType left, GalleryExtendedLocationType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="GalleryExtendedLocationType"/>. </summary>
        public static implicit operator GalleryExtendedLocationType(string value) => new GalleryExtendedLocationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is GalleryExtendedLocationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(GalleryExtendedLocationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

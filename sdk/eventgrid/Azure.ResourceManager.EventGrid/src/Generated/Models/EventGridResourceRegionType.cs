// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Region type of the resource. </summary>
    public readonly partial struct EventGridResourceRegionType : IEquatable<EventGridResourceRegionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EventGridResourceRegionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EventGridResourceRegionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RegionalResourceValue = "RegionalResource";
        private const string GlobalResourceValue = "GlobalResource";

        /// <summary> RegionalResource. </summary>
        public static EventGridResourceRegionType RegionalResource { get; } = new EventGridResourceRegionType(RegionalResourceValue);
        /// <summary> GlobalResource. </summary>
        public static EventGridResourceRegionType GlobalResource { get; } = new EventGridResourceRegionType(GlobalResourceValue);
        /// <summary> Determines if two <see cref="EventGridResourceRegionType"/> values are the same. </summary>
        public static bool operator ==(EventGridResourceRegionType left, EventGridResourceRegionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EventGridResourceRegionType"/> values are not the same. </summary>
        public static bool operator !=(EventGridResourceRegionType left, EventGridResourceRegionType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="EventGridResourceRegionType"/>. </summary>
        public static implicit operator EventGridResourceRegionType(string value) => new EventGridResourceRegionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EventGridResourceRegionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EventGridResourceRegionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

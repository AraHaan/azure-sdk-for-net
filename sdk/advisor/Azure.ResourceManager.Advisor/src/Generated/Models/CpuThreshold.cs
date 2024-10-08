// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Advisor.Models
{
    /// <summary> Minimum percentage threshold for Advisor low CPU utilization evaluation. Valid only for subscriptions. Valid values: 5 (default), 10, 15 or 20. </summary>
    public readonly partial struct CpuThreshold : IEquatable<CpuThreshold>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CpuThreshold"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CpuThreshold(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FiveValue = "5";
        private const string TenValue = "10";
        private const string FifteenValue = "15";
        private const string TwentyValue = "20";

        /// <summary> 5. </summary>
        public static CpuThreshold Five { get; } = new CpuThreshold(FiveValue);
        /// <summary> 10. </summary>
        public static CpuThreshold Ten { get; } = new CpuThreshold(TenValue);
        /// <summary> 15. </summary>
        public static CpuThreshold Fifteen { get; } = new CpuThreshold(FifteenValue);
        /// <summary> 20. </summary>
        public static CpuThreshold Twenty { get; } = new CpuThreshold(TwentyValue);
        /// <summary> Determines if two <see cref="CpuThreshold"/> values are the same. </summary>
        public static bool operator ==(CpuThreshold left, CpuThreshold right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CpuThreshold"/> values are not the same. </summary>
        public static bool operator !=(CpuThreshold left, CpuThreshold right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="CpuThreshold"/>. </summary>
        public static implicit operator CpuThreshold(string value) => new CpuThreshold(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CpuThreshold other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CpuThreshold other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

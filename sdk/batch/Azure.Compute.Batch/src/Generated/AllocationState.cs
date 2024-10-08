// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Compute.Batch
{
    /// <summary> AllocationState enums. </summary>
    public readonly partial struct AllocationState : IEquatable<AllocationState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AllocationState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AllocationState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SteadyValue = "steady";
        private const string ResizingValue = "resizing";
        private const string StoppingValue = "stopping";

        /// <summary> The Pool is not resizing. There are no changes to the number of Compute Nodes in the Pool in progress. A Pool enters this state when it is created and when no operations are being performed on the Pool to change the number of Compute Nodes. </summary>
        public static AllocationState Steady { get; } = new AllocationState(SteadyValue);
        /// <summary> The Pool is resizing; that is, Compute Nodes are being added to or removed from the Pool. </summary>
        public static AllocationState Resizing { get; } = new AllocationState(ResizingValue);
        /// <summary> The Pool was resizing, but the user has requested that the resize be stopped, but the stop request has not yet been completed. </summary>
        public static AllocationState Stopping { get; } = new AllocationState(StoppingValue);
        /// <summary> Determines if two <see cref="AllocationState"/> values are the same. </summary>
        public static bool operator ==(AllocationState left, AllocationState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AllocationState"/> values are not the same. </summary>
        public static bool operator !=(AllocationState left, AllocationState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AllocationState"/>. </summary>
        public static implicit operator AllocationState(string value) => new AllocationState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AllocationState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AllocationState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

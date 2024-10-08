// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    /// <summary> Various states of the SSO resource. </summary>
    public readonly partial struct NewRelicSingleSignOnState : IEquatable<NewRelicSingleSignOnState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NewRelicSingleSignOnState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NewRelicSingleSignOnState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InitialValue = "Initial";
        private const string EnableValue = "Enable";
        private const string DisableValue = "Disable";
        private const string ExistingValue = "Existing";

        /// <summary> Initial. </summary>
        public static NewRelicSingleSignOnState Initial { get; } = new NewRelicSingleSignOnState(InitialValue);
        /// <summary> Enable. </summary>
        public static NewRelicSingleSignOnState Enable { get; } = new NewRelicSingleSignOnState(EnableValue);
        /// <summary> Disable. </summary>
        public static NewRelicSingleSignOnState Disable { get; } = new NewRelicSingleSignOnState(DisableValue);
        /// <summary> Existing. </summary>
        public static NewRelicSingleSignOnState Existing { get; } = new NewRelicSingleSignOnState(ExistingValue);
        /// <summary> Determines if two <see cref="NewRelicSingleSignOnState"/> values are the same. </summary>
        public static bool operator ==(NewRelicSingleSignOnState left, NewRelicSingleSignOnState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NewRelicSingleSignOnState"/> values are not the same. </summary>
        public static bool operator !=(NewRelicSingleSignOnState left, NewRelicSingleSignOnState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="NewRelicSingleSignOnState"/>. </summary>
        public static implicit operator NewRelicSingleSignOnState(string value) => new NewRelicSingleSignOnState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NewRelicSingleSignOnState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NewRelicSingleSignOnState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

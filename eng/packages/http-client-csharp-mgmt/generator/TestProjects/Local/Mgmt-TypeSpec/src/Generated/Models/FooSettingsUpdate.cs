// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace MgmtTypeSpec.Models
{
    /// <summary> The type used for update operations of the FooSettings. </summary>
    public partial class FooSettingsUpdate
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private protected readonly IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        /// <summary> Initializes a new instance of <see cref="FooSettingsUpdate"/>. </summary>
        public FooSettingsUpdate()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FooSettingsUpdate"/>. </summary>
        /// <param name="properties"> The resource-specific properties for this resource. </param>
        /// <param name="additionalBinaryDataProperties"> Keeps track of any properties unknown to the library. </param>
        internal FooSettingsUpdate(FooSettingsUpdateProperties properties, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Properties = properties;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        /// <summary> The resource-specific properties for this resource. </summary>
        public FooSettingsUpdateProperties Properties { get; set; }
    }
}

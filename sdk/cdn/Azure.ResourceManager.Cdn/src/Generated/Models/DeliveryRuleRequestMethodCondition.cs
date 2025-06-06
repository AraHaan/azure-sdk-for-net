// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary>
    /// Defines the RequestMethod condition for the delivery rule.
    /// Serialized Name: DeliveryRuleRequestMethodCondition
    /// </summary>
    public partial class DeliveryRuleRequestMethodCondition : DeliveryRuleCondition
    {
        /// <summary> Initializes a new instance of <see cref="DeliveryRuleRequestMethodCondition"/>. </summary>
        /// <param name="properties">
        /// Defines the parameters for the condition.
        /// Serialized Name: DeliveryRuleRequestMethodCondition.parameters
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public DeliveryRuleRequestMethodCondition(RequestMethodMatchCondition properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
            Name = MatchVariable.RequestMethod;
        }

        /// <summary> Initializes a new instance of <see cref="DeliveryRuleRequestMethodCondition"/>. </summary>
        /// <param name="name">
        /// The name of the condition for the delivery rule.
        /// Serialized Name: DeliveryRuleCondition.name
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="properties">
        /// Defines the parameters for the condition.
        /// Serialized Name: DeliveryRuleRequestMethodCondition.parameters
        /// </param>
        internal DeliveryRuleRequestMethodCondition(MatchVariable name, IDictionary<string, BinaryData> serializedAdditionalRawData, RequestMethodMatchCondition properties) : base(name, serializedAdditionalRawData)
        {
            Properties = properties;
            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="DeliveryRuleRequestMethodCondition"/> for deserialization. </summary>
        internal DeliveryRuleRequestMethodCondition()
        {
        }

        /// <summary>
        /// Defines the parameters for the condition.
        /// Serialized Name: DeliveryRuleRequestMethodCondition.parameters
        /// </summary>
        public RequestMethodMatchCondition Properties { get; set; }
    }
}

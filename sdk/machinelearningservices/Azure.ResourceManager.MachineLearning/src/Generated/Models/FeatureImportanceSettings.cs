// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The FeatureImportanceSettings. </summary>
    public partial class FeatureImportanceSettings
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FeatureImportanceSettings"/>. </summary>
        public FeatureImportanceSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FeatureImportanceSettings"/>. </summary>
        /// <param name="mode"> The mode of operation for computing feature importance. </param>
        /// <param name="targetColumn"> The name of the target column within the input data asset. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FeatureImportanceSettings(FeatureImportanceMode? mode, string targetColumn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Mode = mode;
            TargetColumn = targetColumn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The mode of operation for computing feature importance. </summary>
        [WirePath("mode")]
        public FeatureImportanceMode? Mode { get; set; }
        /// <summary> The name of the target column within the input data asset. </summary>
        [WirePath("targetColumn")]
        public string TargetColumn { get; set; }
    }
}

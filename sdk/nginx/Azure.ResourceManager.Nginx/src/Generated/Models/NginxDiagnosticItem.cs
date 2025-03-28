// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Nginx.Models
{
    /// <summary> A diagnostic is a message associated with an NGINX config. The Analyzer returns diagnostics with a level indicating the importance of the diagnostic with optional category. </summary>
    public partial class NginxDiagnosticItem
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

        /// <summary> Initializes a new instance of <see cref="NginxDiagnosticItem"/>. </summary>
        /// <param name="directive"></param>
        /// <param name="description"></param>
        /// <param name="file"> The filepath of the most relevant config file. </param>
        /// <param name="line"></param>
        /// <param name="message"></param>
        /// <param name="rule"></param>
        /// <param name="level"> Warning or Info. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="directive"/>, <paramref name="description"/>, <paramref name="file"/>, <paramref name="message"/> or <paramref name="rule"/> is null. </exception>
        internal NginxDiagnosticItem(string directive, string description, string file, float line, string message, string rule, NginxDiagnosticLevel level)
        {
            Argument.AssertNotNull(directive, nameof(directive));
            Argument.AssertNotNull(description, nameof(description));
            Argument.AssertNotNull(file, nameof(file));
            Argument.AssertNotNull(message, nameof(message));
            Argument.AssertNotNull(rule, nameof(rule));

            Directive = directive;
            Description = description;
            File = file;
            Line = line;
            Message = message;
            Rule = rule;
            Level = level;
        }

        /// <summary> Initializes a new instance of <see cref="NginxDiagnosticItem"/>. </summary>
        /// <param name="id"> Unique identifier for the diagnostic. </param>
        /// <param name="directive"></param>
        /// <param name="description"></param>
        /// <param name="file"> The filepath of the most relevant config file. </param>
        /// <param name="line"></param>
        /// <param name="message"></param>
        /// <param name="rule"></param>
        /// <param name="level"> Warning or Info. </param>
        /// <param name="category"> Category of warning like Best-practices, Recommendation, Security etc. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NginxDiagnosticItem(string id, string directive, string description, string file, float line, string message, string rule, NginxDiagnosticLevel level, string category, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Directive = directive;
            Description = description;
            File = file;
            Line = line;
            Message = message;
            Rule = rule;
            Level = level;
            Category = category;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NginxDiagnosticItem"/> for deserialization. </summary>
        internal NginxDiagnosticItem()
        {
        }

        /// <summary> Unique identifier for the diagnostic. </summary>
        public string Id { get; }
        /// <summary> Gets the directive. </summary>
        public string Directive { get; }
        /// <summary> Gets the description. </summary>
        public string Description { get; }
        /// <summary> The filepath of the most relevant config file. </summary>
        public string File { get; }
        /// <summary> Gets the line. </summary>
        public float Line { get; }
        /// <summary> Gets the message. </summary>
        public string Message { get; }
        /// <summary> Gets the rule. </summary>
        public string Rule { get; }
        /// <summary> Warning or Info. </summary>
        public NginxDiagnosticLevel Level { get; }
        /// <summary> Category of warning like Best-practices, Recommendation, Security etc. </summary>
        public string Category { get; }
    }
}

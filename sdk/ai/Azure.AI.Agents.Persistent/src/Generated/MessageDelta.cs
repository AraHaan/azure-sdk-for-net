// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.Agents.Persistent
{
    /// <summary> Represents the typed 'delta' payload within a streaming message delta chunk. </summary>
    public partial class MessageDelta
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

        /// <summary> Initializes a new instance of <see cref="MessageDelta"/>. </summary>
        /// <param name="role"> The entity that produced the message. </param>
        /// <param name="content">
        /// The content of the message as an array of text and/or images.
        /// Please note <see cref="MessageDeltaContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MessageDeltaImageFileContent"/> and <see cref="MessageDeltaTextContent"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        internal MessageDelta(MessageRole role, IEnumerable<MessageDeltaContent> content)
        {
            Argument.AssertNotNull(content, nameof(content));

            Role = role;
            Content = content.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="MessageDelta"/>. </summary>
        /// <param name="role"> The entity that produced the message. </param>
        /// <param name="content">
        /// The content of the message as an array of text and/or images.
        /// Please note <see cref="MessageDeltaContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MessageDeltaImageFileContent"/> and <see cref="MessageDeltaTextContent"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MessageDelta(MessageRole role, IReadOnlyList<MessageDeltaContent> content, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Role = role;
            Content = content;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MessageDelta"/> for deserialization. </summary>
        internal MessageDelta()
        {
        }

        /// <summary> The entity that produced the message. </summary>
        public MessageRole Role { get; }
        /// <summary>
        /// The content of the message as an array of text and/or images.
        /// Please note <see cref="MessageDeltaContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MessageDeltaImageFileContent"/> and <see cref="MessageDeltaTextContent"/>.
        /// </summary>
        public IReadOnlyList<MessageDeltaContent> Content { get; }
    }
}

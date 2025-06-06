// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class MediaJobError
    {
        internal static MediaJobError DeserializeMediaJobError(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MediaJobErrorCode? code = default;
            string message = default;
            MediaJobErrorCategory? category = default;
            MediaJobRetry? retry = default;
            IReadOnlyList<MediaJobErrorDetail> details = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    code = property.Value.GetString().ToMediaJobErrorCode();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("category"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    category = property.Value.GetString().ToMediaJobErrorCategory();
                    continue;
                }
                if (property.NameEquals("retry"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retry = property.Value.GetString().ToMediaJobRetry();
                    continue;
                }
                if (property.NameEquals("details"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MediaJobErrorDetail> array = new List<MediaJobErrorDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MediaJobErrorDetail.DeserializeMediaJobErrorDetail(item));
                    }
                    details = array;
                    continue;
                }
            }
            return new MediaJobError(code, message, category, retry, details ?? new ChangeTrackingList<MediaJobErrorDetail>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static MediaJobError FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeMediaJobError(document.RootElement);
        }
    }
}

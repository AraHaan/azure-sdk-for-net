// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class FirewallPolicyData : IUtf8JsonSerializable, IJsonModel<FirewallPolicyData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FirewallPolicyData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FirewallPolicyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPolicyData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirewallPolicyData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                ((IJsonModel<ManagedServiceIdentity>)Identity).Write(writer, options);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Size))
            {
                writer.WritePropertyName("size"u8);
                writer.WriteStringValue(Size);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(RuleCollectionGroups))
            {
                writer.WritePropertyName("ruleCollectionGroups"u8);
                writer.WriteStartArray();
                foreach (var item in RuleCollectionGroups)
                {
                    ((IJsonModel<WritableSubResource>)item).Write(writer, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(BasePolicy))
            {
                writer.WritePropertyName("basePolicy"u8);
                ((IJsonModel<WritableSubResource>)BasePolicy).Write(writer, options);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Firewalls))
            {
                writer.WritePropertyName("firewalls"u8);
                writer.WriteStartArray();
                foreach (var item in Firewalls)
                {
                    ((IJsonModel<WritableSubResource>)item).Write(writer, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ChildPolicies))
            {
                writer.WritePropertyName("childPolicies"u8);
                writer.WriteStartArray();
                foreach (var item in ChildPolicies)
                {
                    ((IJsonModel<WritableSubResource>)item).Write(writer, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ThreatIntelMode))
            {
                writer.WritePropertyName("threatIntelMode"u8);
                writer.WriteStringValue(ThreatIntelMode.Value.ToString());
            }
            if (Optional.IsDefined(ThreatIntelWhitelist))
            {
                writer.WritePropertyName("threatIntelWhitelist"u8);
                writer.WriteObjectValue(ThreatIntelWhitelist, options);
            }
            if (Optional.IsDefined(Insights))
            {
                writer.WritePropertyName("insights"u8);
                writer.WriteObjectValue(Insights, options);
            }
            if (Optional.IsDefined(Snat))
            {
                writer.WritePropertyName("snat"u8);
                writer.WriteObjectValue(Snat, options);
            }
            if (Optional.IsDefined(Sql))
            {
                writer.WritePropertyName("sql"u8);
                writer.WriteObjectValue(Sql, options);
            }
            if (Optional.IsDefined(DnsSettings))
            {
                writer.WritePropertyName("dnsSettings"u8);
                writer.WriteObjectValue(DnsSettings, options);
            }
            if (Optional.IsDefined(ExplicitProxy))
            {
                writer.WritePropertyName("explicitProxy"u8);
                writer.WriteObjectValue(ExplicitProxy, options);
            }
            if (Optional.IsDefined(IntrusionDetection))
            {
                writer.WritePropertyName("intrusionDetection"u8);
                writer.WriteObjectValue(IntrusionDetection, options);
            }
            if (Optional.IsDefined(TransportSecurity))
            {
                writer.WritePropertyName("transportSecurity"u8);
                writer.WriteObjectValue(TransportSecurity, options);
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku, options);
            }
            writer.WriteEndObject();
        }

        FirewallPolicyData IJsonModel<FirewallPolicyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPolicyData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirewallPolicyData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFirewallPolicyData(document.RootElement, options);
        }

        internal static FirewallPolicyData DeserializeFirewallPolicyData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag? etag = default;
            ManagedServiceIdentity identity = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType? type = default;
            AzureLocation? location = default;
            IDictionary<string, string> tags = default;
            string size = default;
            IReadOnlyList<WritableSubResource> ruleCollectionGroups = default;
            NetworkProvisioningState? provisioningState = default;
            WritableSubResource basePolicy = default;
            IReadOnlyList<WritableSubResource> firewalls = default;
            IReadOnlyList<WritableSubResource> childPolicies = default;
            AzureFirewallThreatIntelMode? threatIntelMode = default;
            FirewallPolicyThreatIntelWhitelist threatIntelWhitelist = default;
            FirewallPolicyInsights insights = default;
            FirewallPolicySnat snat = default;
            FirewallPolicySQL sql = default;
            DnsSettings dnsSettings = default;
            FirewallPolicyExplicitProxy explicitProxy = default;
            FirewallPolicyIntrusionDetection intrusionDetection = default;
            FirewallPolicyTransportSecurity transportSecurity = default;
            FirewallPolicySku sku = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = ModelReaderWriter.Read<ManagedServiceIdentity>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), options, AzureResourceManagerNetworkContext.Default);
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("size"u8))
                        {
                            size = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ruleCollectionGroups"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ModelReaderWriter.Read<WritableSubResource>(new BinaryData(Encoding.UTF8.GetBytes(item.GetRawText())), options, AzureResourceManagerNetworkContext.Default));
                            }
                            ruleCollectionGroups = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("basePolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            basePolicy = ModelReaderWriter.Read<WritableSubResource>(new BinaryData(Encoding.UTF8.GetBytes(property0.Value.GetRawText())), options, AzureResourceManagerNetworkContext.Default);
                            continue;
                        }
                        if (property0.NameEquals("firewalls"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ModelReaderWriter.Read<WritableSubResource>(new BinaryData(Encoding.UTF8.GetBytes(item.GetRawText())), options, AzureResourceManagerNetworkContext.Default));
                            }
                            firewalls = array;
                            continue;
                        }
                        if (property0.NameEquals("childPolicies"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ModelReaderWriter.Read<WritableSubResource>(new BinaryData(Encoding.UTF8.GetBytes(item.GetRawText())), options, AzureResourceManagerNetworkContext.Default));
                            }
                            childPolicies = array;
                            continue;
                        }
                        if (property0.NameEquals("threatIntelMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            threatIntelMode = new AzureFirewallThreatIntelMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("threatIntelWhitelist"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            threatIntelWhitelist = FirewallPolicyThreatIntelWhitelist.DeserializeFirewallPolicyThreatIntelWhitelist(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("insights"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            insights = FirewallPolicyInsights.DeserializeFirewallPolicyInsights(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("snat"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            snat = FirewallPolicySnat.DeserializeFirewallPolicySnat(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("sql"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sql = FirewallPolicySQL.DeserializeFirewallPolicySQL(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("dnsSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dnsSettings = DnsSettings.DeserializeDnsSettings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("explicitProxy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            explicitProxy = FirewallPolicyExplicitProxy.DeserializeFirewallPolicyExplicitProxy(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("intrusionDetection"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            intrusionDetection = FirewallPolicyIntrusionDetection.DeserializeFirewallPolicyIntrusionDetection(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("transportSecurity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            transportSecurity = FirewallPolicyTransportSecurity.DeserializeFirewallPolicyTransportSecurity(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("sku"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sku = FirewallPolicySku.DeserializeFirewallPolicySku(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FirewallPolicyData(
                id,
                name,
                type,
                location,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData,
                etag,
                identity,
                size,
                ruleCollectionGroups ?? new ChangeTrackingList<WritableSubResource>(),
                provisioningState,
                basePolicy,
                firewalls ?? new ChangeTrackingList<WritableSubResource>(),
                childPolicies ?? new ChangeTrackingList<WritableSubResource>(),
                threatIntelMode,
                threatIntelWhitelist,
                insights,
                snat,
                sql,
                dnsSettings,
                explicitProxy,
                intrusionDetection,
                transportSecurity,
                sku);
        }

        BinaryData IPersistableModel<FirewallPolicyData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPolicyData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerNetworkContext.Default);
                default:
                    throw new FormatException($"The model {nameof(FirewallPolicyData)} does not support writing '{options.Format}' format.");
            }
        }

        FirewallPolicyData IPersistableModel<FirewallPolicyData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPolicyData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeFirewallPolicyData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FirewallPolicyData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FirewallPolicyData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

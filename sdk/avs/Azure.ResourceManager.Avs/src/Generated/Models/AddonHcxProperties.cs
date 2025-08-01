// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> The properties of an HCX addon. </summary>
    public partial class AddonHcxProperties : AvsPrivateCloudAddonProperties
    {
        /// <summary> Initializes a new instance of <see cref="AddonHcxProperties"/>. </summary>
        /// <param name="offer"> The HCX offer, example VMware MaaS Cloud Provider (Enterprise). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="offer"/> is null. </exception>
        public AddonHcxProperties(string offer)
        {
            Argument.AssertNotNull(offer, nameof(offer));

            Offer = offer;
            AddonType = AddonType.HCX;
        }

        /// <summary> Initializes a new instance of <see cref="AddonHcxProperties"/>. </summary>
        /// <param name="addonType"> Addon type. </param>
        /// <param name="provisioningState"> The state of the addon provisioning. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="offer"> The HCX offer, example VMware MaaS Cloud Provider (Enterprise). </param>
        /// <param name="managementNetwork"> HCX management network. </param>
        /// <param name="uplinkNetwork"> HCX uplink network. </param>
        internal AddonHcxProperties(AddonType addonType, AddonProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData, string offer, string managementNetwork, string uplinkNetwork) : base(addonType, provisioningState, serializedAdditionalRawData)
        {
            Offer = offer;
            ManagementNetwork = managementNetwork;
            UplinkNetwork = uplinkNetwork;
            AddonType = addonType;
        }

        /// <summary> Initializes a new instance of <see cref="AddonHcxProperties"/> for deserialization. </summary>
        internal AddonHcxProperties()
        {
        }

        /// <summary> The HCX offer, example VMware MaaS Cloud Provider (Enterprise). </summary>
        public string Offer { get; set; }
        /// <summary> HCX management network. </summary>
        public string ManagementNetwork { get; set; }
        /// <summary> HCX uplink network. </summary>
        public string UplinkNetwork { get; set; }
    }
}

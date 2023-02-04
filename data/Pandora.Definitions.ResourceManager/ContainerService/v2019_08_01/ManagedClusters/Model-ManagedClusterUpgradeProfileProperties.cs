using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ContainerService.v2019_08_01.ManagedClusters;


internal class ManagedClusterUpgradeProfilePropertiesModel
{
    [JsonPropertyName("agentPoolProfiles")]
    [Required]
    public List<ManagedClusterPoolUpgradeProfileModel> AgentPoolProfiles { get; set; }

    [JsonPropertyName("controlPlaneProfile")]
    [Required]
    public ManagedClusterPoolUpgradeProfileModel ControlPlaneProfile { get; set; }
}

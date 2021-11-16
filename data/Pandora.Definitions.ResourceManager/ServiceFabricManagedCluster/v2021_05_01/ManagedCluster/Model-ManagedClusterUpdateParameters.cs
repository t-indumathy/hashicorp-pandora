using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;

namespace Pandora.Definitions.ResourceManager.ServiceFabricManagedCluster.v2021_05_01.ManagedCluster
{

    internal class ManagedClusterUpdateParametersModel
    {
        [JsonPropertyName("tags")]
        public CustomTypes.Tags? Tags { get; set; }
    }
}
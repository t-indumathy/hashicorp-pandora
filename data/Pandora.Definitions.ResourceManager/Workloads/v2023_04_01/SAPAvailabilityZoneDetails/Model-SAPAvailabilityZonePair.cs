using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Workloads.v2023_04_01.SAPAvailabilityZoneDetails;


internal class SAPAvailabilityZonePairModel
{
    [JsonPropertyName("zoneA")]
    public int? ZoneA { get; set; }

    [JsonPropertyName("zoneB")]
    public int? ZoneB { get; set; }
}

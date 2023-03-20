using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Workloads.v2023_04_01.SAPRecommendations;


internal class SAPSizingRecommendationRequestModel
{
    [JsonPropertyName("appLocation")]
    [Required]
    public string AppLocation { get; set; }

    [JsonPropertyName("databaseType")]
    [Required]
    public SAPDatabaseTypeConstant DatabaseType { get; set; }

    [JsonPropertyName("dbMemory")]
    [Required]
    public int DbMemory { get; set; }

    [JsonPropertyName("dbScaleMethod")]
    public SAPDatabaseScaleMethodConstant? DbScaleMethod { get; set; }

    [JsonPropertyName("deploymentType")]
    [Required]
    public SAPDeploymentTypeConstant DeploymentType { get; set; }

    [JsonPropertyName("environment")]
    [Required]
    public SAPEnvironmentTypeConstant Environment { get; set; }

    [JsonPropertyName("highAvailabilityType")]
    public SAPHighAvailabilityTypeConstant? HighAvailabilityType { get; set; }

    [JsonPropertyName("sapProduct")]
    [Required]
    public SAPProductTypeConstant SapProduct { get; set; }

    [JsonPropertyName("saps")]
    [Required]
    public int Saps { get; set; }
}

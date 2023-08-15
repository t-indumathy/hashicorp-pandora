using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Consumption.v2023_11_01.PriceSheet;


internal class OperationStatusModel
{
    [JsonPropertyName("properties")]
    public PricesheetDownloadPropertiesModel? Properties { get; set; }

    [JsonPropertyName("status")]
    public OperationStatusTypeConstant? Status { get; set; }
}

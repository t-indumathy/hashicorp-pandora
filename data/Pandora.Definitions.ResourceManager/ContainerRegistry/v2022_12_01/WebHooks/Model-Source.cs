using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ContainerRegistry.v2022_12_01.WebHooks;


internal class SourceModel
{
    [JsonPropertyName("addr")]
    public string? Addr { get; set; }

    [JsonPropertyName("instanceID")]
    public string? InstanceID { get; set; }
}

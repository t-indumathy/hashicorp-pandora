using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ContainerRegistry.v2019_06_01_preview.Registries;


internal class CustomRegistryCredentialsModel
{
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    [JsonPropertyName("password")]
    public SecretObjectModel? Password { get; set; }

    [JsonPropertyName("userName")]
    public SecretObjectModel? UserName { get; set; }
}

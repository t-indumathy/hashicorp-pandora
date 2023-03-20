using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ContainerRegistry.v2019_06_01_preview.TaskRuns;

[ValueForType("FileTaskRunRequest")]
internal class FileTaskRunRequestModel : RunRequestModel
{
    [JsonPropertyName("agentConfiguration")]
    public AgentPropertiesModel? AgentConfiguration { get; set; }

    [JsonPropertyName("credentials")]
    public CredentialsModel? Credentials { get; set; }

    [JsonPropertyName("platform")]
    [Required]
    public PlatformPropertiesModel Platform { get; set; }

    [JsonPropertyName("sourceLocation")]
    public string? SourceLocation { get; set; }

    [JsonPropertyName("taskFilePath")]
    [Required]
    public string TaskFilePath { get; set; }

    [JsonPropertyName("timeout")]
    public int? Timeout { get; set; }

    [JsonPropertyName("values")]
    public List<SetValueModel>? Values { get; set; }

    [JsonPropertyName("valuesFilePath")]
    public string? ValuesFilePath { get; set; }
}

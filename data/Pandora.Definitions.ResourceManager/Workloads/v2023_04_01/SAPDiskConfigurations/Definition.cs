using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Workloads.v2023_04_01.SAPDiskConfigurations;

internal class Definition : ResourceDefinition
{
    public string Name => "SAPDiskConfigurations";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new SAPDiskConfigurationsOperation(),
    };
}

using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.PolicyInsights.v2021_10_01.PolicyInsights;

internal class RemediationsListForResourceOperation : Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";

    public override ResourceID? ResourceId() => new ResourceIdId();

    public override Type NestedItemType() => typeof(RemediationModel);

    public override Type? OptionsObject() => typeof(RemediationsListForResourceOperation.RemediationsListForResourceOptions);

    public override string? UriSuffix() => "/providers/Microsoft.PolicyInsights/remediations";

    internal class RemediationsListForResourceOptions
    {
        [QueryStringName("$filter")]
        [Optional]
        public string Filter { get; set; }

        [QueryStringName("$top")]
        [Optional]
        public int Top { get; set; }
    }
}
using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ManagedServices.v2022_10_01.MarketplaceRegistrationDefinitions;

internal class WithoutScopeListOperation : Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";

    public override Type NestedItemType() => typeof(MarketplaceRegistrationDefinitionModel);

    public override Type? OptionsObject() => typeof(WithoutScopeListOperation.WithoutScopeListOptions);

    public override string? UriSuffix() => "/providers/Microsoft.ManagedServices/marketplaceRegistrationDefinitions";

    internal class WithoutScopeListOptions
    {
        [QueryStringName("$filter")]
        [Optional]
        public string Filter { get; set; }
    }
}
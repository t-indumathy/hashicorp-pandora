using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ApiManagement.v2022_08_01.ApiOperation;

internal class ListByApiOperation : Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";

    public override ResourceID? ResourceId() => new ApiId();

    public override Type NestedItemType() => typeof(OperationContractModel);

    public override Type? OptionsObject() => typeof(ListByApiOperation.ListByApiOptions);

    public override string? UriSuffix() => "/operations";

    internal class ListByApiOptions
    {
        [QueryStringName("$filter")]
        [Optional]
        public string Filter { get; set; }

        [QueryStringName("$skip")]
        [Optional]
        public int Skip { get; set; }

        [QueryStringName("tags")]
        [Optional]
        public string Tags { get; set; }

        [QueryStringName("$top")]
        [Optional]
        public int Top { get; set; }
    }
}
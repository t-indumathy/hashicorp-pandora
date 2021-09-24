using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;

namespace Pandora.Definitions.ResourceManager.EventHub.v2018_01_01_preview.NamespacesPrivateLinkResources
{
    internal class PrivateLinkResourcesGetOperation : Operations.GetOperation
    {
        public override ResourceID? ResourceId() => new NamespaceId();

        public override Type? ResponseObject() => typeof(PrivateLinkResourcesListResultModel);

        public override string? UriSuffix() => "/privateLinkResources";


    }
}

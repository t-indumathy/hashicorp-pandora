using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;

namespace Pandora.Definitions.ResourceManager.AppConfiguration.v2020_06_01.PrivateEndpointConnections
{
    internal class DeleteOperation : Operations.DeleteOperation
    {
        public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
                HttpStatusCode.Accepted,
                HttpStatusCode.NoContent,
                HttpStatusCode.OK,
        };

        public override bool LongRunning() => true;

        public override ResourceID? ResourceId() => new PrivateEndpointConnectionId();


    }
}

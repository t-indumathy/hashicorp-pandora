using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;

namespace Pandora.Definitions.ResourceManager.Storage.v2021_04_01.EncryptionScopes;

internal class PutOperation : Operations.PutOperation
{
    public override Type? RequestObject() => typeof(EncryptionScopeModel);

    public override ResourceID? ResourceId() => new EncryptionScopeId();

    public override Type? ResponseObject() => typeof(EncryptionScopeModel);


}
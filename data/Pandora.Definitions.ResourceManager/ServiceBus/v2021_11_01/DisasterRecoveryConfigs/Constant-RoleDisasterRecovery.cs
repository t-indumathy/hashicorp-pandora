using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.ServiceBus.v2021_11_01.DisasterRecoveryConfigs;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum RoleDisasterRecoveryConstant
{
    [Description("Primary")]
    Primary,

    [Description("PrimaryNotReplicating")]
    PrimaryNotReplicating,

    [Description("Secondary")]
    Secondary,
}

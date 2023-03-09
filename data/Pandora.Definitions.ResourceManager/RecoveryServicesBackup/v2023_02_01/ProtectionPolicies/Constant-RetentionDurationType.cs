using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.RecoveryServicesBackup.v2023_02_01.ProtectionPolicies;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum RetentionDurationTypeConstant
{
    [Description("Days")]
    Days,

    [Description("Invalid")]
    Invalid,

    [Description("Months")]
    Months,

    [Description("Weeks")]
    Weeks,

    [Description("Years")]
    Years,
}
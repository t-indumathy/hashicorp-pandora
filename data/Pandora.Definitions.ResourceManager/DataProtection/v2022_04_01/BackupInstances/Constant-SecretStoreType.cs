using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.DataProtection.v2022_04_01.BackupInstances;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum SecretStoreTypeConstant
{
    [Description("AzureKeyVault")]
    AzureKeyVault,

    [Description("Invalid")]
    Invalid,
}

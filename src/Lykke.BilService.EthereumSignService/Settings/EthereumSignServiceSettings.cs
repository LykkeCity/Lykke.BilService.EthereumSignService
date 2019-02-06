using JetBrains.Annotations;
using Lykke.Quintessence.Settings;

namespace Lykke.BilService.EthereumSignService.Settings
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class EthereumSignServiceSettings : SignServiceSettings
    {
        public bool IsMainNet { get; set; }
    }
}
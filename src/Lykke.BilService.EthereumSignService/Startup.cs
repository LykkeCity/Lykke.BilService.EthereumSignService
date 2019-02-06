using JetBrains.Annotations;
using Lykke.BilService.EthereumSignService.Modules;
using Lykke.BilService.EthereumSignService.Settings;
using Lykke.Quintessence;
using Lykke.Sdk;

namespace Lykke.BilService.EthereumSignService
{
    [UsedImplicitly]
    public class Startup : SignServiceStartupBase<EthereumSignServiceSettings>
    {
        protected override string IntegrationName
            => "Ethereum";

        protected override void RegisterAdditionalModules(
            IModuleRegistration modules)
        {
            modules.RegisterModule<EthereumSignServiceModule>();
            
            base.RegisterAdditionalModules(modules);
        }
    }
}
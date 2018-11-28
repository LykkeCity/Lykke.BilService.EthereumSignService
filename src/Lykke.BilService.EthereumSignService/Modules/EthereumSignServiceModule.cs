using Autofac;
using JetBrains.Annotations;
using Lykke.BilService.EthereumSignService.Settings;
using Lykke.Quintessence.Settings;
using Lykke.SettingsReader;

namespace Lykke.BilService.EthereumSignService.Modules
{
    [UsedImplicitly]
    public class EthereumSignServiceModule : Module
    {
        private readonly IReloadingManager<AppSettings<EthereumSignServiceSettings>> _appSettings;

        public EthereumSignServiceModule(
            IReloadingManager<AppSettings<EthereumSignServiceSettings>> appSettings)
        {
            _appSettings = appSettings;
        }

        protected override void Load(
            ContainerBuilder builder)
        {
            
        }
    }
}
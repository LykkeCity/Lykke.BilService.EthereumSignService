using Autofac;
using JetBrains.Annotations;
using Lykke.BilService.EthereumSignService.Settings;
using Lykke.Quintessence.Settings;

namespace Lykke.BilService.EthereumSignService.Modules
{
    [UsedImplicitly]
    public class EthereumSignServiceModule : Module
    {
        private readonly AppSettings<EthereumSignServiceSettings> _appSettings;

        public EthereumSignServiceModule(
            AppSettings<EthereumSignServiceSettings> appSettings)
        {
            _appSettings = appSettings;
        }

        protected override void Load(
            ContainerBuilder builder)
        {
            
        }
    }
}
using System.Threading.Tasks;
using Lykke.BilService.EthereumSignService.Settings;
using Lykke.Quintessence;

namespace Lykke.BilService.EthereumSignService
{
    internal static class Program
    {
        #if DEBUG
        
        private const bool IsDebug = true;
        
        #else

        private const bool IsDebug = false;

        #endif
        
        private static Task Main()
        {
            return SignServiceStarter
                .StartAsync<Startup, EthereumSignServiceSettings>(IsDebug);
        }
    }
}
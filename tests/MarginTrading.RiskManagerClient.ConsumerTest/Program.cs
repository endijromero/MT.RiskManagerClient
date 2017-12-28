using System;
using System.Threading.Tasks;

namespace MarginTrading.RiskManagerClient.ConsumerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Task.Run(async () => await Tests()).Wait();
        }

        private static async Task Tests()
        {
            string key = "margintrading";
            //var service = RiskManagementApiClientFactory.CreateDefaultClient("http://mt-riskmanager.lykke-mt.svc.cluster.local/", "TestAgent");
            //var ivarlimits = await service.ApiIvarlimitGetAllGetAsync(key);
            //Console.WriteLine("ivarlimits={0}", ivarlimits.Count);


            var clientPair = RiskManagementApiClientFactory.CreateDefaultClientsPair("http://mt-riskmanager-demo.mt-rms-demo.svc.cluster.local", "http://mt-riskmanager.mt-rms.svc.cluster.local", "testagent");
            //var demotest = await clientPair.Demo.ApiIvarlimitGetAllGetAsync("margintrading");
            var livetest = await clientPair.Live.ApiIvarlimitGetAllGetAsync("margintrading");
            Console.WriteLine("Tests finished");
            Console.ReadLine();

        }
    }
}

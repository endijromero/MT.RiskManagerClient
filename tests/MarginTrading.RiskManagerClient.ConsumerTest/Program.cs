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
            var service = RiskManagementApiClientFactory.CreateDefaultClient("http://mt-riskmanager.lykke-mt.svc.cluster.local/", "TestAgent");
            var ivarlimits = await service.ApiIvarlimitGetAllGetAsync(key);
            Console.WriteLine("ivarlimits={0}", ivarlimits.Count);
            Console.WriteLine("Tests finished");
            Console.ReadLine();

        }
    }
}

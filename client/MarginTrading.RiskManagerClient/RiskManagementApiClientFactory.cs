using MarginTrading.RiskManagerClient.Internal;
using Microsoft.Rest.TransientFaultHandling;
using System;

namespace MarginTrading.RiskManagerClient
{
    /// <summary>
    /// Factory for easy creating api clients with recomended customizations
    /// </summary>
    public static class RiskManagementApiClientFactory
    {
        /// <summary>
        ///     <p>Creates the api client with recomended customizations.</p>
        ///     <p>These customizations consist of: a retry policy to retry http errors 400 & 500 with a 5 seconds period, and max retry
        ///     count of 6.</p>
        ///     <p>Setting the <paramref name="userAgent" /> is required to detect the requests source on the server side.
        ///     It shoud be set to the name of the appication using the api.</p>
        /// </summary>
        public static IRiskManagementApi CreateDefaultClient(string apiUrl, string userAgent, string apiKey)
        {
            var client = new RiskManagementApi(new Uri(apiUrl), new ApiKeyHeaderAddingHandler(apiKey));
            client.SetRetryPolicy(
                new RetryPolicy<ErrorDetectionStrategy>(new FixedIntervalRetryStrategy(6, TimeSpan.FromSeconds(5))));
            client.SetUserAgent(userAgent);
            return client;
        }
        /// <summary>
        /// <p>Creates the api clients pair with recomended customizations.</p>
        /// <p>These customizations consist of: a retry policy to retry http errors 400 e 500 with a 5 seconds period, and max retry
        /// count of 6.</p>
        /// <p>Setting the <paramref name="userAgent" /> is required to detect the requests source on the server side.
        /// It shoud be set to the name of the appication using the api.</p>
        /// </summary>        
        public static RiskManagementLiveDemoClientsPair CreateDefaultClientsPair(string demoApiUrl,
            string liveApiUrl, string demoApiKey, string liveApiKey, string userAgent)
        {
            return new RiskManagementLiveDemoClientsPair(CreateDefaultClient(demoApiUrl, userAgent, demoApiKey),
                CreateDefaultClient(liveApiUrl, userAgent, liveApiKey));
        }
    }
}

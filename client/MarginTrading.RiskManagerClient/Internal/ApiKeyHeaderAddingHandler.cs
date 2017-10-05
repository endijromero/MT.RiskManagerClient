using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MarginTrading.RiskManagerClient.Internal
{
    public class ApiKeyHeaderAddingHandler :DelegatingHandler
    {
        private readonly string _apiKey;

        public ApiKeyHeaderAddingHandler(string apiKey)
        {
            _apiKey = apiKey;
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Add("api-key", _apiKey);
            return base.SendAsync(request, cancellationToken);
        }
    }
}

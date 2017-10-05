using Microsoft.Rest.TransientFaultHandling;
using System;
using System.Net;

namespace MarginTrading.RiskManagerClient.Internal
{
    public class ErrorDetectionStrategy : ITransientErrorDetectionStrategy
    {     
        public bool IsTransient(Exception ex)
        {
            return ex is HttpRequestWithStatusException httpEx
                   && httpEx.StatusCode != HttpStatusCode.BadRequest
                   && httpEx.StatusCode != HttpStatusCode.InternalServerError;
        }
    }
}

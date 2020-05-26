using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ShuftiPro.Services
{
    public class ShuftiProStatusService : ShuftiProServiceBase
    {
        public ShuftiProStatusService(HttpClient httpClient) : base(httpClient)
        {
        }

        public ShuftiProStatusService(HttpClient httpClient, ShuftiProCredentials credentials) : base(httpClient, credentials)
        {
        }

        public Task<ShuftiProStatus> GetStatusAsync(ShuftiProReference reference, ShuftiProCredentials credentials)
        {
            this.EnsureRequestIsValid(reference);
            return this.MakeCall<ShuftiProStatus>(HttpMethod.Post, new Uri("status", UriKind.Relative), reference, credentials);
        }
    }
}

using System.Net.Http;
using System.Threading.Tasks;

namespace ShuftiPro.Services
{
    internal class ShuftiProBackgroundCheckService : ShuftiProServiceBase, IShuftiProBackgroundCheckService
    {
        public ShuftiProBackgroundCheckService(HttpClient httpClient) : base(httpClient)
        {
        }

        public ShuftiProBackgroundCheckService(HttpClient httpClient, ShuftiProCredentials credentials) : base(httpClient, credentials)
        {
        }

        public Task<ShuftiProOnSiteFeedback> VerifyAsync(ShuftiProBackgroundCheckVerification verification, ShuftiProCredentials credentials = null)
        {
            this.EnsureRequestIsValid(verification);

            return this.MakeCall<ShuftiProOnSiteFeedback>(HttpMethod.Post, null, verification, credentials);
        }
    }
}

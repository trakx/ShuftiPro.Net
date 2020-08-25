using System.Net.Http;
using System.Threading.Tasks;

namespace ShuftiPro.Services
{
    public class ShuftiProOnSiteService : ShuftiProServiceBase
    {
        public ShuftiProOnSiteService(HttpClient httpClient) : base(httpClient)
        {
        }

        public ShuftiProOnSiteService(HttpClient httpClient, ShuftiProCredentials credentials) : base(httpClient, credentials)
        {
        }

        public Task<ShuftiProOnSiteFeedback> VerifyOnSiteAsync(ShuftiProOnSiteVerification verification, ShuftiProCredentials credentials = null)
        {
            this.EnsureRequestIsValid(verification);

            return this.MakeCall<ShuftiProOnSiteFeedback>(HttpMethod.Post, null, verification, credentials);
        }
    }
}

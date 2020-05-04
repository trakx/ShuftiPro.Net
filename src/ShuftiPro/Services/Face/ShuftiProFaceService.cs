using System.Net.Http;
using System.Threading.Tasks;

namespace ShuftiPro.Services
{
    internal class ShuftiProFaceService : ShuftiProServiceBase, IShuftiProFaceService
    {
        public ShuftiProFaceService(HttpClient httpClient) : base(httpClient)
        {
        }

        public ShuftiProFaceService(HttpClient httpClient, ShuftiProCredentials credentials) : base(httpClient, credentials)
        {
        }

        public Task<ShuftiProOnSiteFeedback> VerifyOnSiteAsync(ShuftiProOnSiteFaceVerification verification, ShuftiProCredentials credentials = null)
        {
            this.EnsureRequestIsValid(verification);

            return this.MakeCall<ShuftiProOnSiteFeedback>(HttpMethod.Post, null, verification, credentials);
        }
    }
}

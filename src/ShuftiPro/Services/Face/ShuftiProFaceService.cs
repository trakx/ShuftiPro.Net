using System.Net.Http;
using System.Threading.Tasks;
using ShuftiPro.OnSite;

namespace ShuftiPro.Services
{
    public class ShuftiProFaceService : ShuftiProServiceBase, IShuftiProFaceService
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

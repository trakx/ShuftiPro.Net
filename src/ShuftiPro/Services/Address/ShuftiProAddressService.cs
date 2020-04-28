using System.Net.Http;
using System.Threading.Tasks;
using ShuftiPro.OnSite;

namespace ShuftiPro.Services
{
    public class ShuftiProAddressService : ShuftiProServiceBase, IShuftiProAddressService
    {
        public ShuftiProAddressService(HttpClient httpClient) : base(httpClient)
        {
        }

        public ShuftiProAddressService(HttpClient httpClient, ShuftiProCredentials credentials) : base(httpClient, credentials)
        {
        }

        public Task<ShuftiProOnSiteFeedback> VerifyOnSiteAsync(ShuftiProOnSiteAddressVerification verification, ShuftiProCredentials credentials)
        {
            this.EnsureRequestIsValid(verification);

            return this.MakeCall<ShuftiProOnSiteFeedback>(HttpMethod.Post, null, verification, credentials);
        }
    }
}

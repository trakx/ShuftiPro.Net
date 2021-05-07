using System.Net.Http;
using System.Threading.Tasks;
using ShuftiPro.Options;
using ShuftiPro.Services.Base;

namespace ShuftiPro.Services.Address
{
    internal class ShuftiProAddressService : ShuftiProServiceBase, IShuftiProAddressService
    {
        public ShuftiProAddressService(HttpClient httpClient) : base(httpClient)
        {
        }

        public ShuftiProAddressService(HttpClient httpClient, ShuftiProCredentials credentials) : base(httpClient, credentials)
        {
        }

        public Task<ShuftiProOnSiteFeedback> VerifyOnSiteAsync(ShuftiProOnSiteAddressVerification verification, ShuftiProCredentials credentials = null)
        {
            this.EnsureRequestIsValid(verification);

            return this.MakeCall<ShuftiProOnSiteFeedback>(HttpMethod.Post, null, verification, credentials);
        }
    }
}

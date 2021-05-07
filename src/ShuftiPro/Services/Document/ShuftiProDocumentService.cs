using System.Net.Http;
using System.Threading.Tasks;
using ShuftiPro.Options;
using ShuftiPro.Services.Base;

namespace ShuftiPro.Services.Document
{
    internal class ShuftiProDocumentService : ShuftiProServiceBase, IShuftiProDocumentService
    {
        public ShuftiProDocumentService(HttpClient httpClient) : base(httpClient)
        {
        }

        public ShuftiProDocumentService(HttpClient httpClient, ShuftiProCredentials credentials) : base(httpClient, credentials)
        {
        }

        public Task<ShuftiProOnSiteFeedback> VerifyOnSiteAsync(ShuftiProOnSiteDocumentVerification verification, ShuftiProCredentials credentials = null)
        {
            this.EnsureRequestIsValid(verification);

            return this.MakeCall<ShuftiProOnSiteFeedback>(HttpMethod.Post, null, verification, credentials);
        }

        public Task<ShuftiProOffSiteFeedback> VerifyOffSiteAsync(ShuftiProOffSiteDocumentVerification verification, ShuftiProCredentials credentials = null)
        {
            this.EnsureRequestIsValid(verification);

            return this.MakeCall<ShuftiProOffSiteFeedback>(HttpMethod.Post, null, verification, credentials);
        }
    }
}

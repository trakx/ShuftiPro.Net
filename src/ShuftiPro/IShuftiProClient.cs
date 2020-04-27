using System.Threading.Tasks;
using ShuftiPro.OnSite;

namespace ShuftiPro
{
    public interface IShuftiProClient
    {
        Task<ShuftiProOnSiteFeedback> VerifyDocumentOnSiteAsync(ShuftiProOnSiteDocumentVerification verification,
            ShuftiProCredentials credentials = null);

        Task<ShuftiProOnSiteFeedback> VerifyAddressOnSiteAsync(ShuftiProOnSiteAddressVerification verification,
            ShuftiProCredentials credentials = null);
    }
}

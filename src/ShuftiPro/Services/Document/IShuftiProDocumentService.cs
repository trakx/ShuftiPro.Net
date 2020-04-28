using System.Threading.Tasks;

namespace ShuftiPro.Services
{
    public interface IShuftiProDocumentService
    {
        Task<ShuftiProOnSiteFeedback> VerifyOnSiteAsync(ShuftiProOnSiteDocumentVerification verification, ShuftiProCredentials credentials = null);

        Task<ShuftiProOffSiteFeedback> VerifyOffSiteAsync(ShuftiProOffSiteDocumentVerification verification, ShuftiProCredentials credentials = null);
    }
}

using System.Threading.Tasks;
using ShuftiPro.OnSite;

namespace ShuftiPro
{
    public interface IShuftiProClient
    {
        Task<ShuftiProOnSiteFeedback> OnSiteDocumentVerificationAsync(ShuftiProOnSiteDocumentVerification verification,
            ShuftiProCredentials credentials = null);
    }
}

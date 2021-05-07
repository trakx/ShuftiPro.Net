using System.Threading.Tasks;
using ShuftiPro.Options;
using ShuftiPro.Services.Base;

namespace ShuftiPro.Services.Document
{
    public interface IShuftiProDocumentService
    {
        Task<ShuftiProOnSiteFeedback> VerifyOnSiteAsync(ShuftiProOnSiteDocumentVerification verification, ShuftiProCredentials credentials = null);

        Task<ShuftiProOffSiteFeedback> VerifyOffSiteAsync(ShuftiProOffSiteDocumentVerification verification, ShuftiProCredentials credentials = null);
    }
}

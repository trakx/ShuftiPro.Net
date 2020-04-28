using System.Threading.Tasks;
using ShuftiPro.OnSite;

namespace ShuftiPro.Services
{
    public interface IShuftiProFaceService
    {
        Task<ShuftiProOnSiteFeedback> VerifyOnSiteAsync(ShuftiProOnSiteFaceVerification verification, ShuftiProCredentials credentials = null);
    }
}

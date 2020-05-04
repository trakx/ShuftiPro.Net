using System.Threading.Tasks;

namespace ShuftiPro.Services
{
    public interface IShuftiProFaceService
    {
        Task<ShuftiProOnSiteFeedback> VerifyOnSiteAsync(ShuftiProOnSiteFaceVerification verification, ShuftiProCredentials credentials = null);
    }
}

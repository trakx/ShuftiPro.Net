using System.Threading.Tasks;
using ShuftiPro.Options;
using ShuftiPro.Services.Base;

namespace ShuftiPro.Services.Face
{
    public interface IShuftiProFaceService
    {
        Task<ShuftiProOnSiteFeedback> VerifyOnSiteAsync(ShuftiProOnSiteFaceVerification verification, ShuftiProCredentials credentials = null);
    }
}

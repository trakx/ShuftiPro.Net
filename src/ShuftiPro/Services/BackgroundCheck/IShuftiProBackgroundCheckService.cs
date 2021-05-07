using System.Threading.Tasks;
using ShuftiPro.Options;
using ShuftiPro.Services.Base;

namespace ShuftiPro.Services.BackgroundCheck
{
    public interface IShuftiProBackgroundCheckService
    {
        Task<ShuftiProOnSiteFeedback> VerifyAsync(ShuftiProBackgroundCheckVerification verification, ShuftiProCredentials credentials = null);
    }
}

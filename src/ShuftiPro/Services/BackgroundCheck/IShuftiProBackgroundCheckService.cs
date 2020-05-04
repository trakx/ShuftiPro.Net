using System.Threading.Tasks;

namespace ShuftiPro.Services
{
    public interface IShuftiProBackgroundCheckService
    {
        Task<ShuftiProOnSiteFeedback> VerifyAsync(ShuftiProBackgroundCheckVerification verification, ShuftiProCredentials credentials = null);
    }
}

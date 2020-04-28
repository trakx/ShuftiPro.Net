using System.Threading.Tasks;
using ShuftiPro.OnSite;

namespace ShuftiPro.Services
{
    public interface IShuftiProAddressService
    {
        Task<ShuftiProOnSiteFeedback> VerifyOnSiteAsync(ShuftiProOnSiteAddressVerification verification, ShuftiProCredentials credentials);
    }
}

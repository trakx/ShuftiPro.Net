using System.Threading.Tasks;

namespace ShuftiPro.Services
{
    public interface IShuftiProAddressService
    {
        Task<ShuftiProOnSiteFeedback> VerifyOnSiteAsync(ShuftiProOnSiteAddressVerification verification, ShuftiProCredentials credentials = null);
    }
}

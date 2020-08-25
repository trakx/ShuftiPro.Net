using System.Threading.Tasks;
using ShuftiPro.Services;

namespace ShuftiPro
{
    public interface IShuftiProClient
    {
        IShuftiProAddressService AddressService { get; }

        IShuftiProDocumentService DocumentService { get; }

        IShuftiProBackgroundCheckService BackgroundCheckService { get; }

        IShuftiProFaceService FaceService { get; }

        Task<ShuftiProStatus> GetStatusAsync(ShuftiProReference reference, ShuftiProCredentials credentials = null);

        Task<ShuftiProOnSiteFeedback> VerifyOnSiteAsync(ShuftiProOnSiteVerification verification, ShuftiProCredentials credentials = null);
    }
}

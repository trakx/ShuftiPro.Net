using System.Threading.Tasks;
using ShuftiPro.Options;
using ShuftiPro.Services;
using ShuftiPro.Services.Address;
using ShuftiPro.Services.BackgroundCheck;
using ShuftiPro.Services.Base;
using ShuftiPro.Services.Document;
using ShuftiPro.Services.Face;

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

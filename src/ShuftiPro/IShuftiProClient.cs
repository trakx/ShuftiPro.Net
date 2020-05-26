using System.Threading.Tasks;
using ShuftiPro.Services;

namespace ShuftiPro
{
    public interface IShuftiProClient
    {
        IShuftiProAddressService AddressService { get; }

        IShuftiProDocumentService DocumentService { get; }

        IShuftiProBackgroundCheckService BackgroundCheckService { get; set; }

        IShuftiProFaceService FaceService { get; }

        Task<ShuftiProStatus> GetStatusAsync(ShuftiProReference reference, ShuftiProCredentials credentials = null);
    }
}

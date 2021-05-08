using System.Threading.Tasks;
using ShuftiPro.Contracts;
using ShuftiPro.Options;

namespace ShuftiPro
{
    public interface IShuftiPro
    {
        Task<ShuftiProFeedback> VerifyAsync(ShuftiProVerification verification);

        Task<ShuftiProFeedback> VerifyAsync(ShuftiProVerification verification, ShuftiProCredentials requestCredentials);

        Task<ShuftiProStatus> GetStatusAsync(ShuftiProReference reference);

        Task<ShuftiProStatus> GetStatusAsync(ShuftiProReference reference, ShuftiProCredentials requestCredentials);
    }
}

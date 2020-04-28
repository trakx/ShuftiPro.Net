using ShuftiPro.Services;

namespace ShuftiPro
{
    public interface IShuftiProClient
    {
        IShuftiProAddressService AddressService { get; }

        IShuftiProDocumentService DocumentService { get; }
    }
}

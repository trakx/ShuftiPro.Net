using ShuftiPro.Contracts.Abstractions;
using ShuftiPro.Enums;

namespace ShuftiPro.Contracts
{
    public class ShuftiProConsentData : IShuftiProConsentData
    {
        public string Text { get; set; }
        public ShuftiProConsentType[] SelectedTypes { get; set; }

        public ShuftiProConsentType[] SupportedTypes { get; set; }
    }
}

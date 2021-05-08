using ShuftiPro.Contracts.Abstractions;
using ShuftiPro.Enums;

namespace ShuftiPro.Contracts
{
    public class ShuftiProConsent : IShuftiProConsent
    {
        public string Proof { get; set; }

        public string Text { get; set; }

        public bool? WithFace { get; set; }

        public ShuftiProConsentType[] SupportedTypes { get; set; }
    }
}

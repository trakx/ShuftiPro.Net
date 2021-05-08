using ShuftiPro.Contracts.Abstractions;

namespace ShuftiPro.Contracts
{
    public class ShuftiProFeedbackData : IShuftiProFeedbackData
    {
        public ShuftiProAddressData Address { get; set; }

        public ShuftiProDocumentData Document { get; set; }

        public ShuftiProBackgroundCheckData BackgroundCheck { get; set; }

        public ShuftiProConsentData Consent { get; set; }
    }
}

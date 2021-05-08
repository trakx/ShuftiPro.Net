using ShuftiPro.Contracts.Abstractions;

namespace ShuftiPro.Contracts
{
    public class ShuftiProFeedbackResult : IShuftiProFeedbackResult
    {
        public bool? Face { get; set; }

        public bool? BackgroundChecks { get; set; }

        public ShuftiProAddressResult Address { get; set; }

        public ShuftiProDocumentResult Document { get; set; }

        public ShuftiProConsentResult Consent { get; set; }
    }
}

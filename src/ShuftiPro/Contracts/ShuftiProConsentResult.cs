using ShuftiPro.Contracts.Abstractions;

namespace ShuftiPro.Contracts
{
    public class ShuftiProConsentResult : IShuftiProFeedbackConsentResult
    {
        public bool? SelectedType { get; set; }

        public bool? Consent { get; set; }
    }
}

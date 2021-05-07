using ShuftiPro.Contracts.Abstractions;

namespace ShuftiPro.Contracts
{
    public class ShuftiProFeedbackResult : IShuftiProFeedbackResult
    {
        public bool? Face { get; set; }

        public bool? BackgroundChecks { get; set; }

        public ShuftiProFeedbackAddressResult Address { get; set; }
    }
}

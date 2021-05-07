using ShuftiPro.Contracts.Abstractions;
using ShuftiPro.Enums;
using ShuftiPro.Services.Base;

namespace ShuftiPro.Contracts
{
    public class ShuftiProFeedback : IShuftiProFeedback
    {
        public string Reference { get; set; }

        public ShuftiProEvent Event { get; set; }

        public string Email { get; set; }

        public string Country { get; set; }

        public ShuftiProFeedbackError Error { get; set; }

        public string VerificationUrl { get; set; }

        public ShuftiProFeedbackResult Result { get; set; }
    }
}

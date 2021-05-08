using ShuftiPro.Contracts.Abstractions;

namespace ShuftiPro.Contracts
{
    public class ShuftiProFeedbackError : IShuftiProFeedbackError
    {
        public string Service { get; set; }

        public string Key { get; set; }

        public string Message { get; set; }
    }
}

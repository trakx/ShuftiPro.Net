using ShuftiPro.Contracts.Abstractions;

namespace ShuftiPro.Contracts
{
    public class ShuftiProFeedbackDocumentResult : IShuftiProFeedbackDocumentResult
    {
        public bool? SelectedType { get; set; }

        public bool? IssueDate { get; set; }

        public bool? Document { get; set; }

        public bool? DocumentCountry { get; set; }

        public bool? DocumentVisibility { get; set; }

        public bool? DocumentMustNotBeExpired { get; set; }

        public bool? DocumentProof { get; set; }
    }
}

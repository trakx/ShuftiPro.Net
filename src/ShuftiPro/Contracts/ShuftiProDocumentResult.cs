using ShuftiPro.Contracts.Abstractions;

namespace ShuftiPro.Contracts
{
    public class ShuftiProDocumentResult : IShuftiProFeedbackDocumentResult
    {
        public bool? SelectedType { get; set; }

        public bool? Name { get; set; }

        public bool? Gender { get; set; }

        public bool? IssueDate { get; set; }

        public bool? ExpiryDate { get; set; }

        public bool? DayOfBirth { get; set; }

        public bool? Document { get; set; }

        public bool? DocumentNumber { get; set; }

        public bool? DocumentCountry { get; set; }

        public bool? DocumentVisibility { get; set; }

        public bool? DocumentMustNotBeExpired { get; set; }

        public bool? DocumentProof { get; set; }

        public bool? FaceOnDocumentMatched { get; set; }
    }
}

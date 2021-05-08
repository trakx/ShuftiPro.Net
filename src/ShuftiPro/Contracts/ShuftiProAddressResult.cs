using ShuftiPro.Contracts.Abstractions;

namespace ShuftiPro.Contracts
{
    public class ShuftiProAddressResult : IShuftiProFeedbackAddressResult
    {
        public bool? SelectedType { get; set; }

        public bool? Name { get; set; }

        public bool? IssueDate { get; set; }

        public bool? FullAddress { get; set; }

        public bool? AddressDocument { get; set; }

        public bool? AddressDocumentProof { get; set; }

        public bool? AddressDocumentCountry { get; set; }

        public bool? AddressDocumentVisibility { get; set; }

        public bool? AddressDocumentMustBeNotExpired { get; set; }

        public bool? PartialAddressMatchWithIdAndUtilityBill { get; set; }

        public bool? MatchAddressProofsWithDocumentProofs { get; set; }
    }
}

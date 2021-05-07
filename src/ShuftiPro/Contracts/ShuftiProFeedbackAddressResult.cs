using ShuftiPro.Contracts.Abstractions;

namespace ShuftiPro.Contracts
{
    public class ShuftiProFeedbackAddressResult : IShuftiProFeedbackAddressResult
    {
        public bool? SelectedType { get; set; }

        public bool? FullAddress { get; set; }

        public bool? AddressDocument { get; set; }

        public bool? AddressDocumentCountry { get; set; }

        public bool? PartialAddressMatchWithIdAndUtilityBill { get; set; }

        public bool? AddressDocumentVisibility { get; set; }

        public bool? AddressDocumentMustBeNotExpired { get; set; }
    }
}

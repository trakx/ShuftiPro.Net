using Newtonsoft.Json;

namespace ShuftiPro.Contracts.Abstractions
{
    public interface IShuftiProFeedbackAddressResult
    {
        [JsonProperty("selected_type")]
        bool? SelectedType { get; set; }

        [JsonProperty("full_address")]
        bool? FullAddress { get; set; }

        [JsonProperty("address_document")]
        bool? AddressDocument { get; set; }

        [JsonProperty("address_document_country")]
        bool? AddressDocumentCountry { get; set; }

        [JsonProperty("partial_address_match_with_id_and_utility_bill")]
        bool? PartialAddressMatchWithIdAndUtilityBill { get; set; }

        [JsonProperty("address_document_visibility")]
        bool? AddressDocumentVisibility { get; set; }

        [JsonProperty("address_document_must_not_be_expired")]
        bool? AddressDocumentMustBeNotExpired { get; set; }
    }
}
using Newtonsoft.Json;

namespace ShuftiPro.Models
{
    public class ShuftiProVerificationAddressResult
    {
        [JsonProperty("selected_type")]
        public bool? SelectedType { get; set; }

        [JsonProperty("full_address")]
        public bool? FullAddress { get; set; }

        [JsonProperty("address_document")]
        public bool? AddressDocument { get; set; }

        [JsonProperty("address_document_country")]
        public bool? AddressDocumentCountry { get; set; }

        [JsonProperty("partial_address_match_with_id_and_utility_bill")]
        public bool? PartialAddressMatchWithIdAndUtilityBill { get; set; }

        [JsonProperty("address_document_visibility")]
        public bool? AddressDocumentVisibility { get; set; }

        [JsonProperty("address_document_must_not_be_expired")]
        public bool? AddressDocumentMustBeNotExpired { get; set; }
    }
}

using Newtonsoft.Json;
using ShuftiPro.Converters;

namespace ShuftiPro.Contracts.Abstractions
{
    public interface IShuftiProFeedbackAddressResult
    {
        [JsonProperty("selected_type")]
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        bool? SelectedType { get; set; }

        [JsonProperty("name")]
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        bool? Name { get; set; }

        [JsonProperty("issue_date")]
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        bool? IssueDate { get; set; }

        [JsonProperty("full_address")]
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        bool? FullAddress { get; set; }

        [JsonProperty("address_document")]
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        bool? AddressDocument { get; set; }

        [JsonProperty("address_document_proof")]
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        bool? AddressDocumentProof { get; set; }

        [JsonProperty("address_document_country")]
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        bool? AddressDocumentCountry { get; set; }

        [JsonProperty("address_document_visibility")]
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        bool? AddressDocumentVisibility { get; set; }

        [JsonProperty("address_document_must_not_be_expired")]
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        bool? AddressDocumentMustBeNotExpired { get; set; }

        [JsonProperty("partial_address_match_with_id_and_utility_bill")]
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        bool? PartialAddressMatchWithIdAndUtilityBill { get; set; }

        [JsonProperty("match_address_proofs_with_document_proofs")]
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        bool? MatchAddressProofsWithDocumentProofs { get; set; }
    }
}
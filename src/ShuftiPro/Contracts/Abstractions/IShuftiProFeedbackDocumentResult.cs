using Newtonsoft.Json;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProFeedbackDocumentResult
    {
        [JsonProperty("selected_type")]
        bool? SelectedType { get; set; }

        [JsonProperty("issue_date")]
        bool? IssueDate { get; set; }

        [JsonProperty("document")]
        bool? Document { get; set; }

        [JsonProperty("document_country")]
        bool? DocumentCountry { get; set; }

        [JsonProperty("document_visibility")]
        bool? DocumentVisibility { get; set; }

        [JsonProperty("document_must_not_be_expired")]
        bool? DocumentMustNotBeExpired { get; set; }

        [JsonProperty("document_proof")]
        bool? DocumentProof { get; set; }
    }
}
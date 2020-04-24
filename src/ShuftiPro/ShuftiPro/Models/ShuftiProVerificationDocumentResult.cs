using Newtonsoft.Json;

namespace ShuftiPro.Models
{
    public class ShuftiProVerificationDocumentResult
    {
        [JsonProperty("selected_type")]
        public bool? SelectedType { get; set; }

        [JsonProperty("issue_date")]
        public bool? IssueDate { get; set; }

        [JsonProperty("document")]
        public bool? Document { get; set; }

        [JsonProperty("document_country")]
        public bool? DocumentCountry { get; set; }

        [JsonProperty("document_visibility")]
        public bool? DocumentVisibility { get; set; }

        [JsonProperty("document_must_not_be_expired")]
        public bool? DocumentMustNotBeExpired { get; set; }
    }
}

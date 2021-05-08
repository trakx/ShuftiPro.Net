using Newtonsoft.Json;
using ShuftiPro.Converters;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProFeedbackDocumentResult
    {
        [JsonProperty("selected_type")]
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        bool? SelectedType { get; set; }

        [JsonProperty("name")]
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        bool? Name { get; set; }

        [JsonProperty("gender")]
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        bool? Gender { get; set; }

        [JsonProperty("issue_date")]
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        bool? IssueDate { get; set; }

        [JsonProperty("expiry_date")]
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        bool? ExpiryDate { get; set; }

        [JsonProperty("dob")]
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        bool? DayOfBirth { get; set; }

        [JsonProperty("document")]
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        bool? Document { get; set; }

        [JsonProperty("document_number")]
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        bool? DocumentNumber { get; set; }

        [JsonProperty("document_country")]
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        bool? DocumentCountry { get; set; }

        [JsonProperty("document_visibility")]
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        bool? DocumentVisibility { get; set; }

        [JsonProperty("document_must_not_be_expired")]
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        bool? DocumentMustNotBeExpired { get; set; }

        [JsonProperty("document_proof")]
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        bool? DocumentProof { get; set; }

        [JsonProperty("face_on_document_matched")]
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        bool? FaceOnDocumentMatched { get; set; }
    }
}
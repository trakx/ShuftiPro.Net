using Newtonsoft.Json;

namespace ShuftiPro.Services.Base
{
    public class ShuftiProDocumentResult
    {
        [JsonProperty("name")]
        public bool? Name { get; set; }

        [JsonProperty("dob")]
        public bool? DateOfBirth { get; set; }

        [JsonProperty("expiry_date")]
        public bool? ExpiryDate { get; set; }

        [JsonProperty("issue_date")]
        public bool? IssueDate { get; set; }

        [JsonProperty("document")]
        public bool? Document { get; set; }

        [JsonProperty("document_number")]
        public bool? DocumentNumber { get; set; }
    }
}

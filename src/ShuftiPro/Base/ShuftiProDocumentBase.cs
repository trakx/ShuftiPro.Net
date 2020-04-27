using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using ShuftiPro.Enums;

namespace ShuftiPro.Base
{
    public class ShuftiProDocumentBase
    {
        [Required]
        [JsonProperty("supported_types", Required = Required.Always)]
        public DocumentType[] SupportedTypes { get; set; }

        [JsonConverter(typeof(ShuftiProDateTimeConverter))]
        [JsonProperty("dob", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DayOfBirth { get; set; }

        [StringLength(100, MinimumLength = 2)]
        [JsonProperty("document_number", NullValueHandling = NullValueHandling.Ignore)]
        public string DocumentNumber { get; set; }

        [JsonConverter(typeof(ShuftiProDateTimeConverter))]
        [JsonProperty("issue_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? IssueDate { get; set; }

        [JsonConverter(typeof(ShuftiProDateTimeConverter))]
        [JsonProperty("expiry_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ExpiryDate { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public ShuftiProName Name { get; set; }
    }
}

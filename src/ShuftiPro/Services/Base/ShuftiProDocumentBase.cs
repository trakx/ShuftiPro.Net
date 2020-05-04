using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace ShuftiPro.Services
{
    public class ShuftiProDocumentBase
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public ShuftiProName Name { get; set; }

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
    }
}

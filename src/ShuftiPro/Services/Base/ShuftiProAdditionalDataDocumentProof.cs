using System;
using Newtonsoft.Json;

namespace ShuftiPro.Services
{
    public class ShuftiProAdditionalDataDocumentProof
    {
        [JsonProperty("dob"), JsonConverter(typeof(ShuftiProDateTimeConverter))]
        public DateTime? DayOfBirth { get; set; }

        [JsonProperty("cast")]
        public string Cast { get; set; }

        [JsonProperty("face")]
        public string Face { get; set; }

        [JsonProperty("signature")]
        public string Signature { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("nationality")]
        public string Nationality { get; set; }

        [JsonProperty("place_of_birth")]
        public string PlaceOfBirth { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("document_type")]
        public string DocumentType { get; set; }

        [JsonProperty("document_number")]
        public string DocumentNumber { get; set; }

        [JsonProperty("personal_number")]
        public string PersonalNumber { get; set; }

        [JsonProperty("expiry_date"), JsonConverter(typeof(ShuftiProDateTimeConverter))]
        public DateTime? ExpiryDate { get; set; }

        [JsonProperty("issue_date"), JsonConverter(typeof(ShuftiProDateTimeConverter))]
        public DateTime? IssueDate { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("authority")]
        public int Authority { get; set; }

        [JsonProperty("first_name_native")]
        public string FirstNameNative { get; set; }

        [JsonProperty("last_name_native")]
        public string LastNameNative { get; set; }

        [JsonProperty("nationality_native")]
        public string NationalityNative { get; set; }

        [JsonProperty("gender_native")]
        public string GenderNative { get; set; }

        [JsonProperty("country_native")]
        public string CountryNative { get; set; }

        [JsonProperty("document_type_native")]
        public string DocumentTypeNative { get; set; }
    }
}

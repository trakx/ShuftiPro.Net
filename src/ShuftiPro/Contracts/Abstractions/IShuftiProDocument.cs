using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using ShuftiPro.Converters;
using ShuftiPro.Enums;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProDocument
    {
        [JsonConverter(typeof(ShuftiProByteArrayToBase64Converter))]
        [JsonProperty("proof", NullValueHandling = NullValueHandling.Ignore)]
        byte[] Proof { get; set; }

        [JsonConverter(typeof(ShuftiProByteArrayToBase64Converter))]
        [JsonProperty("additional_proof", NullValueHandling = NullValueHandling.Ignore)]
        byte[] AdditionalProof { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        ShuftiProName Name { get; set; }

        [JsonProperty("gender", NullValueHandling = NullValueHandling.Ignore)]
        ShuftiProGenderType? Gender { get; set; }

        [JsonConverter(typeof(ShuftiProDateTimeConverter))]
        [JsonProperty("dob", NullValueHandling = NullValueHandling.Ignore)]
        DateTime? DayOfBirth { get; set; }

        [StringLength(100, MinimumLength = 2)]
        [JsonProperty("document_number", NullValueHandling = NullValueHandling.Ignore)]
        string DocumentNumber { get; set; }

        [JsonConverter(typeof(ShuftiProDateTimeConverter))]
        [JsonProperty("issue_date", NullValueHandling = NullValueHandling.Ignore)]
        DateTime? IssueDate { get; set; }

        [JsonConverter(typeof(ShuftiProDateTimeConverter))]
        [JsonProperty("expiry_date", NullValueHandling = NullValueHandling.Ignore)]
        DateTime? ExpiryDate { get; set; }

        [JsonProperty("supported_types", Required = Required.Always)]
        ShuftiProDocumentType[] SupportedTypes { get; set; }

        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("fetch_enhanced_data", DefaultValueHandling = DefaultValueHandling.Ignore)]
        bool? FetchEnhancedData { get; set; }

        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("backside_proof_required", NullValueHandling = NullValueHandling.Ignore)]
        bool? BacksideProofRequired { get; set; }

        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("allow_offline", NullValueHandling = NullValueHandling.Ignore)]
        bool? AllowOffline { get; set; }

        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("allow_online", NullValueHandling = NullValueHandling.Ignore)]
        bool? AllowOnline { get; set; }

        [JsonProperty("verification_instructions", NullValueHandling = NullValueHandling.Ignore)]
        ShuftiProVerificationInstruction Instruction { get; set; }
    }
}
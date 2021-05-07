using System;
using Newtonsoft.Json;
using ShuftiPro.Converters;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProAddress : IShuftiProAddressBase
    {
        [JsonConverter(typeof(ShuftiProByteArrayToBase64Converter))]
        [JsonProperty("proof", NullValueHandling = NullValueHandling.Ignore)]
        byte[] Proof { get; set; }

        [JsonConverter(typeof(ShuftiProDateTimeConverter))]
        [JsonProperty("issue_date", NullValueHandling = NullValueHandling.Ignore)]
        DateTime? IssueDate { get; set; }

        [JsonProperty("address_fuzzy_match", NullValueHandling = NullValueHandling.Ignore)]
        bool? AddressFuzzyMatch { get; set; }

        [JsonProperty("backside_proof_required", NullValueHandling = NullValueHandling.Ignore)]
        bool? BacksideProofRequired { get; set; }

        [JsonProperty("verification_instructions", NullValueHandling = NullValueHandling.Ignore)]
        ShuftiProVerificationInstruction Instruction { get; set; }
    }
}

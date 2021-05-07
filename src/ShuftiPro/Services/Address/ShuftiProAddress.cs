using System;
using Newtonsoft.Json;
using ShuftiPro.Converters;

namespace ShuftiPro.Services.Address
{
    public class ShuftiProAddress : ShuftiProAddressBase
    {
        [JsonConverter(typeof(ShuftiProDateTimeConverter))]
        [JsonProperty("issue_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? IssueDate { get; set; }

        [JsonProperty("address_fuzzy_match", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AddressFuzzyMatch { get; set; }

        [JsonProperty("backside_proof_required", NullValueHandling = NullValueHandling.Ignore)]
        public bool? BacksideProofRequired { get; set; }
    }
}

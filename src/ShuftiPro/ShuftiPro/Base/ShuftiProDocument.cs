using Newtonsoft.Json;

namespace ShuftiPro.Base
{
    public class ShuftiProDocument : ShuftiProDocumentBase
    {
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("fetch_enhanced_data", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool FetchEnhancedData { get; set; }

        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("backside_proof_required", NullValueHandling = NullValueHandling.Ignore)]
        public bool? BacksideProofRequired { get; set; }
    }
}

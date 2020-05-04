using Newtonsoft.Json;

namespace ShuftiPro.Services
{
    public class ShuftiProProofData
    {
        [JsonProperty("face")]
        public ShuftiProProof Face { get; set; }

        [JsonProperty("document")]
        public ShuftiProProof Document { get; set; }

        [JsonProperty("address")]
        public ShuftiProProof Address { get; set; }

        [JsonProperty("consent")]
        public ShuftiProProof Consent { get; set; }
    }
}

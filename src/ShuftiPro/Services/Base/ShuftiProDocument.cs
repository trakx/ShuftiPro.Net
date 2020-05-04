using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using ShuftiPro.Enums;

namespace ShuftiPro.Services
{
    public class ShuftiProDocument : ShuftiProDocumentBase
    {
        [Required]
        [JsonProperty("supported_types", Required = Required.Always)]
        public ShuftiProDocumentType[] SupportedTypes { get; set; }

        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("fetch_enhanced_data", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? FetchEnhancedData { get; set; }

        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("backside_proof_required", NullValueHandling = NullValueHandling.Ignore)]
        public bool? BacksideProofRequired { get; set; }
    }
}

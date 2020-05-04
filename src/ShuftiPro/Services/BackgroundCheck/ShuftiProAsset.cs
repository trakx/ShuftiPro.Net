using Newtonsoft.Json;

namespace ShuftiPro.Services
{
    public class ShuftiProAsset
    {
        [JsonProperty("public_url")]
        public string PublicUrl { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

using Newtonsoft.Json;

namespace ShuftiPro.Services
{
    public class ShuftiProAdditionalData
    {
        [JsonProperty("document")]
        public ShuftiProAdditionalDataDocument Document { get; set; }
    }
}

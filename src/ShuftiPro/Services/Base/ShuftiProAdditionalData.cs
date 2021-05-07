using Newtonsoft.Json;

namespace ShuftiPro.Services.Base
{
    public class ShuftiProAdditionalData
    {
        [JsonProperty("document")]
        public ShuftiProAdditionalDataDocument Document { get; set; }
    }
}

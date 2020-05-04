using Newtonsoft.Json;

namespace ShuftiPro.Services
{
    public class ShuftiProProof
    {
        [JsonProperty("proof")]
        public string Proof { get; set; }
    }
}

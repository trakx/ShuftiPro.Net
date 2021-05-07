using Newtonsoft.Json;

namespace ShuftiPro.Services.Base
{
    public class ShuftiProProof
    {
        [JsonProperty("proof")]
        public string Proof { get; set; }
    }
}

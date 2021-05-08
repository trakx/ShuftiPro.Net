using Newtonsoft.Json;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProProof
    {
        [JsonProperty("proof", NullValueHandling = NullValueHandling.Ignore)]
        string Proof { get; set; }
    }
}

using Newtonsoft.Json;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProProof
    {
        [JsonProperty("proof")]
        string Proof { get; set; }
    }
}

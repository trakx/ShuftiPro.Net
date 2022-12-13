using Newtonsoft.Json;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProAdditionalProof
    {
        [JsonProperty("additional_proof", NullValueHandling = NullValueHandling.Ignore)]
        string AdditionalProof { get; set; }
    }
}

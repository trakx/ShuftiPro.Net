using Newtonsoft.Json;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProDocumentProof : IShuftiProProof
    {
        [JsonProperty("additional_proof", NullValueHandling = NullValueHandling.Ignore)]
        string AdditionalProof { get; set; }
    }
}

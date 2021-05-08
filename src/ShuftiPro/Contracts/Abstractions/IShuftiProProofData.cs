using Newtonsoft.Json;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProProofData
    {
        [JsonProperty("face")]
        ShuftiProProof Face { get; set; }

        [JsonProperty("document")]
        ShuftiProDocumentProof Document { get; set; }

        [JsonProperty("address")]
        ShuftiProProof Address { get; set; }

        [JsonProperty("consent")]
        ShuftiProProof Consent { get; set; }
    }
}

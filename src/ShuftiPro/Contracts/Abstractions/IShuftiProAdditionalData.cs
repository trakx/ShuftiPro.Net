using Newtonsoft.Json;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProAdditionalData
    {
        [JsonProperty("document")]
        ShuftiProAdditionalDataDocument Document { get; set; }
    }
}

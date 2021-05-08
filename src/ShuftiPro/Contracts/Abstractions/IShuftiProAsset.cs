using Newtonsoft.Json;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProAsset
    {
        [JsonProperty("_url")]
        string Url { get; set; }

        [JsonProperty("source")]
        string Source { get; set; }

        [JsonProperty("type")]
        string Type { get; set; }
    }
}

using Newtonsoft.Json;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProAmlData
    {
        [JsonProperty("filters", NullValueHandling = NullValueHandling.Ignore)]
        string[] Filters { get; set; }

        [JsonProperty("hits", NullValueHandling = NullValueHandling.Ignore)]
        ShuftiProHit[] Hits { get; set; }
    }
}

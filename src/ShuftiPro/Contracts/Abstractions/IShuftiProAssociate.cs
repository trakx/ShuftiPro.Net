using Newtonsoft.Json;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProAssociate
    {
        [JsonProperty("association")]
        string Association { get; set; }

        [JsonProperty("name")]
        string Name { get; set; }
    }
}

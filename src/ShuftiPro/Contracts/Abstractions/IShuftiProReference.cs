using Newtonsoft.Json;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProReference
    {
        [JsonProperty("reference", Required = Required.Always)]
        string Reference { get; set; }
    }
}

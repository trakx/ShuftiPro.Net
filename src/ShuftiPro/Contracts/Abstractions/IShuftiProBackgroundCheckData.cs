using Newtonsoft.Json;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProBackgroundCheckData : IShuftiProBackgroundCheckBase
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        ShuftiProNameData Name { get; set; }

        [JsonProperty("aml_data", NullValueHandling = NullValueHandling.Ignore)]
        ShuftiProAmlData AmlData { get; set; }
    }
}

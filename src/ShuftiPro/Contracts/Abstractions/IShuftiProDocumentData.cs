using Newtonsoft.Json;
using ShuftiPro.Enums;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProDocumentData : IShuftiProDocumentBase
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        ShuftiProNameData Name { get; set; }

        [JsonProperty("selected_type", Required = Required.Always)]
        ShuftiProDocumentType[] SelectedTypes { get; set; }
    }
}

using Newtonsoft.Json;
using ShuftiPro.Enums;

namespace ShuftiPro.Contracts.Abstractions
{
    internal interface IShuftiProAddressInfo : IShuftiProAddressBase
    {
        [JsonProperty("selected_type")]
        ShuftiProDocumentType[] SelectedType { get; set; }
    }
}

using Newtonsoft.Json;
using ShuftiPro.Enums;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProConsentData : IShuftiProConsentBase
    {
        [JsonProperty("selected_type")]
        ShuftiProConsentType[] SelectedTypes { get; set; }
    }
}

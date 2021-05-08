using Newtonsoft.Json;
using ShuftiPro.Enums;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProConsentBase
    {
        [JsonProperty("text")]
        string Text { get; set; }

        [JsonProperty("supported_types")]
        ShuftiProConsentType[] SupportedTypes { get; set; }
    }
}

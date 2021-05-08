using Newtonsoft.Json;
using ShuftiPro.Converters;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProFeedbackConsentResult
    {
        [JsonProperty("selected_type")]
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        bool? SelectedType { get; set; }

        [JsonProperty("consent")]
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        bool? Consent { get; set; }
    }
}

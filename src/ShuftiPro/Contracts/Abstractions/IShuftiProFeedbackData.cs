using Newtonsoft.Json;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProFeedbackData
    {
        [JsonProperty("address")]
        ShuftiProAddressData Address { get; set; }

        [JsonProperty("document")]
        ShuftiProDocumentData Document { get; set; }

        [JsonProperty("background_checks")]
        ShuftiProBackgroundCheckData BackgroundCheck { get; set; }

        [JsonProperty("consent")]
        ShuftiProConsentData Consent { get; set; }
    }
}

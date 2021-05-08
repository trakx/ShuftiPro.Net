using Newtonsoft.Json;
using ShuftiPro.Converters;

namespace ShuftiPro.Contracts.Abstractions
{
    public interface IShuftiProFeedbackResult
    {
        [JsonProperty("face")]
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        bool? Face { get; set; }

        [JsonProperty("background_checks")]
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        bool? BackgroundChecks { get; set; }

        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        ShuftiProAddressResult Address { get; set; }

        [JsonProperty("document", NullValueHandling = NullValueHandling.Ignore)]
        ShuftiProDocumentResult Document { get; set; }

        [JsonProperty("consent", NullValueHandling = NullValueHandling.Ignore)]
        ShuftiProConsentResult Consent { get; set; }
    }
}
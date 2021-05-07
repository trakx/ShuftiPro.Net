using Newtonsoft.Json;

namespace ShuftiPro.Contracts.Abstractions
{
    public interface IShuftiProFeedbackResult
    {
        [JsonProperty("face")]
        bool? Face { get; set; }

        [JsonProperty("background_checks")]
        bool? BackgroundChecks { get; set; }

        [JsonProperty("address")]
        ShuftiProFeedbackAddressResult Address { get; set; }
    }
}